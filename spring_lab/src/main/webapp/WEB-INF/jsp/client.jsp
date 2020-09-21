<%@ page language="java" contentType="text/html;  charset=UTF-8" pageEncoding="UTF-8" %>
<%@ taglib prefix="form" uri="http://www.springframework.org/tags/form"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN"
"http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html;" >
    <title>Клиент</title>
</head>
<body>
<div align="center">
    <h2>Редактирование ваших данных</h2>
    <form:form action="edit" method="post" modelAttribute="client">
        <table border="0" cellpadding="5">
            <tr>
                <td>ID: </td>
                <td><form:hidden required="required" path="id"/></td>
            </tr>
            <tr>
                <td>Name: </td>
                <td><form:input required="required" path="name"/></td>
            </tr>
            <tr>
                <td>Surname: </td>
                <td><form:input required="required" path="surname"/></td>
            </tr>
            <tr>
                <td>Father name: </td>
                <td><form:input required="required" path="fathername"/></td>
            </tr>
            <tr>
                <td>Phone number: </td>
                <td><form:input required="required" path="phoneNumber"  pattern=".{10}"/></td>
            </tr>
            <tr>
                <td>Passport: </td>
                <td><form:input required="required" path="passport"  pattern="^[A-Za-z]{2}\\d{7}$"/></td>
            </tr>
            <tr>
                <td colspan="2"><input type="submit" value="сохранить"></td>
            </tr>
        </table>
    </form:form>
</div>
</body>
</html>
