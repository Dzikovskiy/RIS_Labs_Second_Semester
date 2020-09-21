package by.dzikovskiy.entity;

import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import javax.persistence.*;

@Entity
@Getter
@Setter
@NoArgsConstructor
public class Client {
    @Id
    private Long id;
    private String name;
    private String surname;
    private String fathername;
    private long phoneNumber;
    private String passport;
    private int numberOfBookedTickets;

    @OneToOne(cascade = CascadeType.ALL)
    @JoinColumn(name = "ticket_id", referencedColumnName = "id")
    private Ticket ticket;


}
