namespace PolyFood.Common.Common;

public class Constant
{
    public const string LinkRouter = "api/[Controller]/[Action]";

    public static class User
    {
        public const string UsernameNotFound = "Username can not be null";
        public const string Password = "password can not be null";
        public const string PasswordRegex = @"^(?=.*[A-Z]).{8,}$";

        public const string PasswordRegexMessage =
            "Password must contain at least one uppercase letter and be at least 8 characters long";

        public const string UserNotFound = "User not found exception";
        public const string UserCanNotBeNull = "User can not be null";
    }
    
    public static class Role
    {
        public const string User = "User";
        public const string Admin = "Admin";
    }
    
    public static class ClaimType
    {
        public const string Name = "name";
        public const string Id = "Id";
    }

    public static class Jwt
    {
        public const string SecretKey =
            "THIS IS USED TO SIGN AND VERIFY JWT TOKENS, REPLACE IT WITH YOUR OWN SECRET, IT CAN BE ANY STRING";

        public const string ValidAudience = "http://localhost:5274";
        public const string ValidIssuer = "http://localhost:7261";
        public const string Bearer = "Bearer ";
    }

    public static class Product
    {
        public const string ProductNameNotNull = "Product name can't be null ";
        public const string ImageNotNull = "Image can not be null ";
        public const string Price = "Price must be greater than zero";
    }


    public static class AccountException
    {
        public const string UsernameIsExist = "Username was existed";
        public const string EmailIsExist = "Email was existed";
    }

    public static class Authority
    {
        public const string AuthorityNameNotFound = "Authority name not found";
    }

    public static class Mail
    {
        public const string From = "kienc2pro@gmail.com";
        public const string SmtpServer = "smtp.gmail.com";
        public const int Port = 465;
        public const string UserName = "kienc2pro@gmail.com";
        public const string Password = "wdwo ckhq aefh tdjp";
        public const string ConfirmMailUrl = "";
        public const string XOAUTH2 = "XOAUTH2";
    }

    public static class Html
    {
        public const string Button =
            "<button style=\"background-color: #008CBA; border-radius: 20px; color: white; padding: 15px 32px; text-align: center; text-decoration: none; display: inline-block; font-size: 16px; margin: 4px 2px; cursor: pointer; \" type=\"submit\">Confirm</button>";
    }

    public static class SubjectList
    {
        public const string Welcome = "Welcome to Poly Food";
    }

    public static class ServeException
    {
        public const string Invalid = "Serve invalid";
    }

    public static class Connectings
    {
        public const string Data = "Data Source=ADMIN-PC ;Initial Catalog= test ;Integrated Security=True; TrustServerCertificate=True";
    }
}