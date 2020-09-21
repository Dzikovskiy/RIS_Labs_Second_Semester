package by.dzikovskiy.service;

import by.dzikovskiy.entity.Client;
import by.dzikovskiy.entity.Ticket;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class TicketProcessor {
    @Autowired
    private ClientService clientService;
    @Autowired
    private TicketService ticketService;

    public void buyTicket(long id, int booked_seats){
        Ticket ticket = ticketService.get(id);
        ticket.setBooked_seats(booked_seats);
        ticketService.save(ticket);

        Client client = clientService.get(1L);
        client.setTicket(ticket);
        clientService.save(client);
    }

}
