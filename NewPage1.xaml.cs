namespace TUCanteen;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}
	// Event handler for the Login button
        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            // Example: Retrieving input values
            string username = EntryName.Text; // Assuming the Entry for username has x:Name="usernameEntry"
            string password = EntryPassword.Text; // Assuming the Entry for password has x:Name="passwordEntry"

            // Validate credentials
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                await DisplayAlert("Error", "Please enter both username and password.", "OK");
                return;
            }

            // Perform login logic here
            // Example: Dummy check for demo purposes
            if (username == "admin" && password == "password")
            {
                await DisplayAlert("Success", "Login successful!", "OK");
                // Navigate to another page or perform further actions
            }
            else
            {
                await DisplayAlert("Error", "Invalid username or password.", "OK");
            }
        }

        // Event handler for the "Forgot Password" link
        private async void OnForgotPasswordTapped(object sender, EventArgs e)
        {
            // Example: Navigate to Forgot Password Page or show instructions
            await DisplayAlert("Forgot Password", "Please contact support@example.com to reset your password.", "OK");
        }
	

}