package by.dzikovskiy.controller;

import by.dzikovskiy.entity.Client;
import by.dzikovskiy.service.ClientService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.servlet.ModelAndView;

@Controller
public class ClientController {

    @Autowired
    private ClientService clientService;

    @GetMapping("/edit")
    public ModelAndView getClientView(@RequestParam(value = "id", required = false) Long id) {
        if(id==null){
            id=0L;
        }
        Client client = clientService.get(id);
        ModelAndView mav = new ModelAndView("client");
        mav.addObject("client", client);
        return mav;
    }

    @PostMapping("/edit")
    public String saveOrEditClient(@ModelAttribute("client") Client client) {
        clientService.save(client);

        return "redirect:/";
    }

    @RequestMapping("/delete")
    public String deleteClient(@RequestParam long id){
        clientService.delete(id);
        return "redirect:/";
    }

}
