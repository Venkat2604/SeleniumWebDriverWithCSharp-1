namespace POM
{
    public static class Config
    {
        public static string BaseURL = "http://testing.todorvachev.com";

        public static class Credentials
        {
            public static class Valid
            {
                public static string Username = "ValidUser";
                public static string Password = "abcd1234!";
                public static string RepeatPassword = "abcd1234!";
                public static string Email = "example@example.com";
            }

            public static class Invalid
            {
                public static class Username
                {
                    public static string FourCharacters = "Abcd";
                    public static string ThirteenCharacters = "AbcdAbcdAbcdA";
                }

                public static class Password
                {
                    public static string FourCharacters = "Abcd";
                    public static string ThirteenCharacters = "AbcdAbcdAbcdA";
                }

                public static class Email
                {
                    // public static string ShortEmail = 
                }


            }
        }

        public static class AlertMessages
        {
            public static string SuccessfulLogin = "Succesful login!";
        }

    }
}