<%-- 
    Document   : index
    Created on : Apr 27, 2017, 9:16:45 PM
    Author     : home
--%>

<%@page import="pojos.NhanVien"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
    </head>
    <body>
        <form action="display.jsp">
            <select name="age">
                <c:forEach begin="1" var="i" end="100">
                    <option>${i}</option>
                </c:forEach>
            </select>
            <input type="submit" value="Send"/>
        </form>
    </body>
</html>
