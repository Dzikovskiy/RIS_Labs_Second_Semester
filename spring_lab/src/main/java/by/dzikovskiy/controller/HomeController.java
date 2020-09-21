package by.dzikovskiy.controller;

import by.dzikovskiy.entity.Client;
import by.dzikovskiy.entity.Ticket;
import by.dzikovskiy.service.ClientService;
import by.dzikovskiy.service.TicketService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.servlet.ModelAndView;

import java.util.ArrayList;
import java.util.List;

@Controller
public class HomeController {
    @Autowired
    private ClientService clientService;
    @Autowired
    private TicketService ticketService;

    @RequestMapping("/")
    public ModelAndView home() {

        Client client = clientService.get(1L);
        List<Client> list = new ArrayList<>();
        list.add(client);

        List<Ticket> ticketList = ticketService.listAll();

        ModelAndView mav = new ModelAndView("index");
        mav.addObject("listClient",list);
        mav.addObject("listTicket",ticketList);
        return mav;
    }

}
