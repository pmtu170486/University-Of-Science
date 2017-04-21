/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package demos.main;

import demos.DTO.NhanVien;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;
import java.util.Properties;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author home
 */
public class JDBCDemos {

    public Connection getConnection() {
        Connection conn = null;
        try {
            Class.forName("com.mysql.jdbc.Driver");
            Properties connectionProps = new Properties();
            connectionProps.put("user", "root");
            connectionProps.put("password", "");
            String ConnectionString = "jdbc:mysql://localhost:3306/QuanLyNhanVien";
            conn = DriverManager.getConnection(ConnectionString, connectionProps);
        } catch (Exception e) {
            e.printStackTrace();
        }
        return conn;
    }

    public List<NhanVien> getAll() {
        Connection conn = getConnection();
        String query = "SELECT id, name, address FROM NhanVien";
        ResultSet rs = null;
        List<NhanVien> lst = new ArrayList<>();
        try {
            if (conn != null) {
                Statement st = conn.createStatement();
                rs = st.executeQuery(query);
                NhanVien nv = null;
                while (rs.next()) {
                    nv = new NhanVien();
                    nv.setId(rs.getInt("id"));
                    nv.setName(rs.getString("name"));
                    nv.setAddress(rs.getString("address"));
                    lst.add(nv);
                }

            }
        } catch (Exception e) {
            e.printStackTrace();
        } finally {
            if (conn != null) {
                try {
                    rs.close();
                    conn.close();
                } catch (SQLException ex) {
                    Logger.getLogger(JDBCDemos.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
        }
        return lst;
    }

    public int insert(NhanVien nv) {
        Connection conn = getConnection();
        int result = 0;
        String query = "INSERT INTO NhanVien (name,address) values(?,?)";
        try {
            if (conn != null) {
                PreparedStatement pre = conn.prepareStatement(query);
                pre.setString(1, nv.getName());
                pre.setString(2, nv.getAddress());
                result = pre.executeUpdate();
                if (result > 0) {
                    return result;
                }
            }
        } catch (Exception e) {
            e.printStackTrace();
        } finally {
            if (conn != null) {
                try {
                    conn.close();
                } catch (SQLException ex) {
                    Logger.getLogger(JDBCDemos.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
        }
        return result;
    }

    public int delete(int id) {
        Connection conn = getConnection();
        int result = 0;
        String sp = "{call XoaNhanVien(?)}";
        try {
            if (conn != null) {
                CallableStatement call = conn.prepareCall(sp);
                call.setInt(1, id);
                result = call.executeUpdate();
                if (result > 0) {
                    return result;
                }
            }
        } catch (Exception e) {
            e.printStackTrace();
        } finally {
            if (conn != null) {
                try {
                    conn.close();
                } catch (SQLException ex) {
                    Logger.getLogger(JDBCDemos.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
        }
        return result;
    }

    public int update(NhanVien nv) {
        Connection conn = getConnection();
        int result = 0;
        String query = "UPDATE  NhanVien SET name = ? , address = ? WHERE id=?";
        try {
            if (conn != null) {
                PreparedStatement pre = conn.prepareStatement(query);
                pre.setString(1, nv.getName());
                pre.setString(2, nv.getAddress());
                pre.setInt(3, nv.getId());
                result = pre.executeUpdate();
                if (result > 0) {
                    return result;
                }
            }
        } catch (Exception e) {
            e.printStackTrace();
        } finally {
            if (conn != null) {
                try {
                    conn.close();
                } catch (SQLException ex) {
                    Logger.getLogger(JDBCDemos.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
        }
        return result;
    }

    public static void main(String[] args) {
        JDBCDemos demo = new JDBCDemos();
        List<NhanVien> list = demo.getAll();
        for (NhanVien nv : list) {
            System.out.printf("%d \t %s \t %s %n", nv.getId(), nv.getName(), nv.getAddress());
        }

    }

}
