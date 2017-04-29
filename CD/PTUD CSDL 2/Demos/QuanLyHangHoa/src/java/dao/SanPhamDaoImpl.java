/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao;

import DataConnection.ConnectionManagement;
import dto.SanPham;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;
import java.util.Properties;

/**
 *
 * @author home
 */
public class SanPhamDaoImpl implements SanPhamDao {

    @Override
    public List<SanPham> getAll() {
        List<SanPham> list = new ArrayList<>();
        Connection conn = new ConnectionManagement().getConnection();
        if (conn != null) {
            try {
                String query = "SELECT id,tensp,quycach,gia,nhasx FROM sanpham";
                Statement st = conn.createStatement();
                ResultSet rs = st.executeQuery(query);
                while (rs.next()) {
                    SanPham sp = new SanPham();
                    sp.setId(rs.getInt("id"));
                    sp.setTensp(rs.getString("tensp"));
                    sp.setQuycach(rs.getString("quycach"));
                    sp.setGia(rs.getBigDecimal("gia"));
                    sp.setNhasx(rs.getString("nhasx"));
                    list.add(sp);
                }
            } catch (Exception e) {
                e.printStackTrace();
            } finally {
                try {
                    if (conn != null) {
                        conn.close();
                    }
                } catch (Exception e) {
                }
            }

        }
        return list;
    }
}
