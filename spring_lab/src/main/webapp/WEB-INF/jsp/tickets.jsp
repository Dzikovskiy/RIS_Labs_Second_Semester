<%@ page language="java" contentType="text/html;  charset=UTF-8" pageEncoding="UTF-8" %>
<%@ taglib prefix="form" uri="http://www.springframework.org/tags/form"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN"
"http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html;" >
    <title>Tickets</title>
</head>
<body>
<div align="center">
    <h2>Создание билета</h2>
    <form:form action="/ticket/edit" method="post" modelAttribute="ticket">
        <table border="0" cellpadding="5">
            <tr>
                <td>ID: </td>
                <td><form:hidden required="required" path="id"/></td>
            </tr>
            <tr>
                <td>Route: </td>
                <td><form:input required="required" path="route"/></td>
            </tr>
            <tr>
                <td>Free seats: </td>
                <td><form:input required="required" path="free_seats"/></td>
            </tr>
            <tr>
                <td>Booked seats: </td>
                <td><form:input required="required" path="booked_seats"/></td>
            </tr>
            <tr>
                <td>Date: </td>
                <td><form:input required="required" path="date"/></td>
            </tr>
            <tr>
                <td colspan="2"><input type="submit" value="сохранить"></td>
            </tr>
        </table>
    </form:form>
</div>
</body>
</html>
