<%@ page language="java" contentType="text/html;  charset=UTF-8" pageEncoding="UTF-8" %>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01
Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; ">
    <title>Автобусы</title>
</head>
<body>
<div align="center">



    <h3><a href="/edit?id=${client.id<=0? 0:client.id}">Регистрация ваших данных</a></h3>
    <h2>Ваши данные</h2>
    <table border="1" cellpadding="5">
        <tr>
            <th>ID</th>
            <th>Имя</th>
            <th>Фамилия</th>
            <th>Отчество</th>
            <th>Телефон</th>
            <th>Номер паспорта</th>
            <th>Номер вашего билета</th>
            <th>Кол-во билетов</th>
            <th>Действия</th>
        </tr>
        <c:forEach items="${listClient}" var="client">
            <tr>
                <td>${client.id}</td>
                <td>${client.name}</td>
                <td>${client.surname}</td>
                <td>${client.fathername}</td>
                <td>${client.phoneNumber<=0? "": client.phoneNumber}</td>
                <td>${client.passport}</td>
                <td>${client.ticket.id}</td>
                <td>${client.ticket.booked_seats}</td>
                <td>
                    <c:if test="${client.id>0}">
                        <a href="/edit?id=${client.id}">Редактировать</a>

                        <a href="/delete?id=${client.id}">Удалить</a>
                    </c:if>
                </td>
            </tr>
        </c:forEach>
    </table>



    <h2>Билеты на автобус</h2>
    <table border="1" cellpadding="5">
        <tr>
            <th>ID</th>
            <th>Маршрут</th>
            <th>Всего</th>
            <th>Занятые места</th>
            <th>Дата</th>
        </tr>
        <c:forEach items="${listTicket}" var="ticket">
            <tr>
                <td>${ticket.id}</td>
                <td>${ticket.route}</td>
                <td>${ticket.free_seats}</td>
                <td>${ticket.booked_seats}</td>
                <td>${ticket.date}</td>
                <td>
                    <form action="/ticket/buy" method="post">
                        <input type="hidden" value="${ticket.id}" id="id" name="id">
                        <input type="number" id="booked_seats" name="booked_seats" min="1" max="${ticket.free_seats}" required="required">
                        <input type="submit" value="Submit">
                    </form>
                </td>
            </tr>
        </c:forEach>
    </table>
</div>


<a href="/ticket/edit">Создать билет</a>
</body>
</html>
