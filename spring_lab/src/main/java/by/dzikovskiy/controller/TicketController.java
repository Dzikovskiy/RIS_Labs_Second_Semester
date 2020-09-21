package by.dzikovskiy.controller;

import by.dzikovskiy.entity.Ticket;
import by.dzikovskiy.service.TicketProcessor;
import by.dzikovskiy.service.TicketService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestParam;

import java.util.Map;

@Controller
public class TicketController {

    @Autowired
    private TicketService ticketService;
    @Autowired
    private TicketProcessor ticketProcessor;

    @GetMapping("/ticket/edit")
    public String getTicketView(Map<String, Object> model) {
        Ticket ticket = new Ticket();
        model.put("ticket", ticket);
        return "tickets";
    }

    @PostMapping("/ticket/edit")
    public String saveTicket(@ModelAttribute("ticket") Ticket ticket) {
        ticketService.save(ticket);
        return "redirect:/";
    }

    @PostMapping("/ticket/buy")
    public String buyTicket(@RequestParam long id, @RequestParam int booked_seats) {
        ticketProcessor.buyTicket(id, booked_seats);
        return "redirect:/";
    }


}
