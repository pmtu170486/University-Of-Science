package dao.Impl;

import pojos.Person;

/**
 * Created by home on 23-04-2017.
 */
public interface PersonDao {
    public Person findById(Long id);

    public void create(Person p);

    public void update(Person p);

    public void delete(Long id);
}
