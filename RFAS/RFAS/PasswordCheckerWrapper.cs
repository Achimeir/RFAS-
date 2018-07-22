namespace Models
{
    // Class for wrapping the Zxcvbn password strength checker library.
    public static class PasswordCheckerWrapper
    {
        // The function receives a string representing a string and returns the strength of it(1-5)
        public static int getPasswordScore(string psw)
        {
            Zxcvbn.Zxcvbn pswEval = new Zxcvbn.Zxcvbn();
            return pswEval.EvaluatePassword(psw).Score;
        }

    }
}
