package dao.Impl;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.jdbc.core.RowMapper;
import org.springframework.stereotype.Repository;
import pojos.Person;

import java.sql.ResultSet;
import java.sql.SQLException;

/**
 * Created by home on 23-04-2017.
 */
@Repository
public class PersonDaoImpl implements PersonDao {

    private JdbcTemplate jdbcTemplate;

    @Autowired
    public void setJdbcTemplate(JdbcTemplate jdbcTemplate) {
        this.jdbcTemplate = jdbcTemplate;
    }

    public Person findById(final Long id) {
        return (Person) jdbcTemplate.queryForObject("select first_name, last_name from t_person where id=?", new RowMapper() {
            public Object mapRow(ResultSet resultSet, int i) throws SQLException {
                Person p = new Person();
                p.setId(id);
                p.setFirstName(resultSet.getString("first_name"));
                p.setLastName(resultSet.getString("last_name"));
                return p;
            }
        }, id);
    }

    public void create(Person p) {
        jdbcTemplate.update("insert into t_person(id,first_name,last_name) values(t_person_sequence.nextval,?,?)",p.getFirstName(),p.getLastName());
    }

    public void update(Person p) {
        jdbcTemplate.update("update t_person set first_name=?, last_name=? where id=? ",p.getFirstName(),p.getLastName(),p.getId());
    }

    public void delete(Long id) {
        jdbcTemplate.update("delete from t_person where id=?",id);
    }
}
