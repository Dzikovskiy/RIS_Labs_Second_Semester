package by.dzikovskiy.service;

import by.dzikovskiy.entity.Client;
import by.dzikovskiy.repository.ClientRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

@Service
@Transactional
public class ClientService {

    @Autowired
    private ClientRepository clientRepository;

    public void save(Client client) {
        if (client.getId() != null) {
            if (clientRepository.findById(client.getId()).isPresent()) {
                Client clientToUpdate = clientRepository.findById(1L).get();
                clientToUpdate.setName(client.getName());
                clientToUpdate.setSurname(client.getSurname());
                clientToUpdate.setFathername(client.getFathername());
                clientToUpdate.setPhoneNumber(client.getPhoneNumber());
                clientToUpdate.setPassport(client.getPassport());
                clientRepository.save(clientToUpdate);
            }
        }
        client.setId(1L);
        clientRepository.save(client);
    }

    public Client get(Long id) {
        if (clientRepository.findById(id).isPresent()) {
            return clientRepository.findById(id).get();
        } else {
            return new Client();
        }
    }

    public void delete(Long id){
        clientRepository.deleteById(id);
    }

}
