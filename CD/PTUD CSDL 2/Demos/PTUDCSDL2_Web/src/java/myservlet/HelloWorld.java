/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package myservlet;

import demos.DTO.NhanVien;
import demos.main.JDBCDemos;
import java.io.IOException;
import java.util.List;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 *
 * @author home
 */
@WebServlet("/servlet/helloworld")
public class HelloWorld extends HttpServlet {

    @Override
    protected void service(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
        resp.setContentType("text/html");
        JDBCDemos demo = new JDBCDemos();
        List<NhanVien> list = demo.getAll();
        StringBuilder builder = new StringBuilder();
        builder.append("<table border='1' width='50%'><tr><th>ID</th><th>Name</th><th>Address</th></tr>");
        for (NhanVien nv : list) {
            builder.append("<tr>");
            builder.append("<td>" + nv.getId() + "</td>");
            builder.append("<td>" + nv.getName() + "</td>");
            builder.append("<td>" + nv.getAddress() + "</td>");
            builder.append("</tr>");
        }
        builder.append("</table>");
        resp.getWriter().print(builder.toString());
        
    }

}
