package services;

import dao.Impl.PersonDao;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;
import pojos.Person;

/**
 * Created by home on 23-04-2017.
 */
@Service
@Transactional
public class PersonService {
    private PersonDao personDao;

    @Autowired
    public void setPersonDao(PersonDao personDao) {
        this.personDao = personDao;
    }

    public Person findById(Long id) {
        return personDao.findById(id);
    }

    public void create(Person p) {
        personDao.create(p);
    }

    public void update(Person p) {
        personDao.update(p);
    }

    public void delete(Long id) {
        personDao.delete(id);
    }
}
