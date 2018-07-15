namespace Models
{
    public static class PasswordCheckerWrapper
    {
        public static int getPasswordScore(string psw)
        {
            Zxcvbn.Zxcvbn pswEval = new Zxcvbn.Zxcvbn();
            return pswEval.EvaluatePassword(psw).Score;
        }

    }
}
