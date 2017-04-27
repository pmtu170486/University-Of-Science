<%-- 
    Document   : display
    Created on : Apr 27, 2017, 9:23:58 PM
    Author     : home
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"  %>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
    </head>
    <body>
        <c:choose>
            <c:when test="${param.age > 18}">
                <h3>Bạn đã trên 18 tuổi</h3>    
            </c:when>
            <c:otherwise>
                <h3>Bạn đã chưa đủ 18 tuổi</h3>    
            </c:otherwise>
        </c:choose>
        
    </body>
</html>
