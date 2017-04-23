import org.junit.Assert;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.test.context.ContextConfiguration;
import org.springframework.test.context.junit4.SpringJUnit4ClassRunner;
import org.springframework.transaction.annotation.Transactional;
import pojos.Person;
import services.PersonService;

/**
 * Created by home on 23-04-2017.
 */
@RunWith(SpringJUnit4ClassRunner.class)
@Transactional
@ContextConfiguration("classpath:/applicationContext.xml")
public class PersonServiceIntegrateTests {
    @Autowired
    private PersonService personService;

    @Autowired
    private JdbcTemplate jdbcTemplate;

    @Test
    public void shouldCreateNewPerson(){
        Person person=new Person();
        person.setFirstName("test");
        person.setLastName("test");
        long countBeforeInsert = jdbcTemplate.queryForObject("select count(*) from t_person",Long.class);
        Assert.assertEquals(2,countBeforeInsert);
        personService.create(person);
        long countAfterInsert = jdbcTemplate.queryForObject("select count(*) from t_person",Long.class);
        Assert.assertEquals(3,countAfterInsert);

    }


}
