using TechTalk.SpecFlow;

namespace BDD;

[Binding]
public class UserLoginTests
{
    User user;
    private bool loginResult;

    [Given(@"a user exists with username ""(.*)"" and password ""(.*)""")]
    public void GivenAUserExistsWithUsernameAndPassword(string userName, string password)
    {
        user = new User(userName, password);
    }

    [When(@"the user tries to login with username ""(.*)"" and password ""(.*)""")]
    public void WhenTheUserTiesToLoginWithUsernameAndPassword(string username, string password)
    {
        loginResult = (user.UserName == username && user.Password == password);
    }

    [Then(@"the login should be successful")]
    public void ThenTheLoginShouldBeSuccessful()
    {
        Assert.True(loginResult);
    }
}

public class User
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public User(string userName, string password)
    {
        UserName = userName;
        Password = password;
    }
}