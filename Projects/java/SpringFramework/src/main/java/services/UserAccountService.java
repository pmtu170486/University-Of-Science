package services;


/**
 * Created by home on 23-04-2017.
 */
public class UserAccountService {

    public UserAccountService() {
        this.name = "Alvin Reyes";
        this.description = "Account is actived with enough funds";
        this.details = "PHP10000.00";
    }

    private String name;
    private String description;
    private String details;

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public String getDetails() {
        return details;
    }

    public void setDetails(String details) {
        this.details = details;
    }
}
