Feature: User Login

	Scenario: Successful login with valid credentails
		Given a user exists with username "test" and password "1"
		When the user tries to login with username "test" and password "1"
		Then the login should be successful