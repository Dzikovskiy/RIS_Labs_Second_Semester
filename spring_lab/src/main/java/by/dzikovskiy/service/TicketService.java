package by.dzikovskiy.service;

import by.dzikovskiy.entity.Ticket;
import by.dzikovskiy.repository.TicketRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import java.util.List;

@Service
@Transactional
public class TicketService {

    @Autowired
    private TicketRepository ticketRepository;

    public void save(Ticket ticket) {
        ticketRepository.save(ticket);
    }

    public List<Ticket> listAll() {
        return (List<Ticket>) ticketRepository.findAll();
    }

    public Ticket get(Long id) {
        return ticketRepository.findById(id).get();
    }

    public void delete(Long id) {
        ticketRepository.deleteById(id);
    }
}
