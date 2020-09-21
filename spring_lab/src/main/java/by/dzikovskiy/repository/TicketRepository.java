package by.dzikovskiy.repository;

import by.dzikovskiy.entity.Ticket;
import org.springframework.data.repository.CrudRepository;

public interface TicketRepository extends CrudRepository<Ticket, Long> {

}
