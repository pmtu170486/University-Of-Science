import org.springframework.context.support.ClassPathXmlApplicationContext;
import services.UserAccountService;

/**
 * Created by home on 23-04-2017.
 */
public class MyTest {

    public static void main(String[] args) {
        ClassPathXmlApplicationContext context = new ClassPathXmlApplicationContext("classpath*:/applicationContext.xml");
        UserAccountService userAccountService = (UserAccountService) context.getBean("userAccountService");
        System.out.println(userAccountService.getName());
        System.out.println(userAccountService.getDescription());
        System.out.println(userAccountService.getDetails());

    }
}
