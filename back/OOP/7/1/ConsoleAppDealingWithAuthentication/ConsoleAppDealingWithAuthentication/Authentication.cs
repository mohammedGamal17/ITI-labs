namespace ConsoleAppDealingWithAuthentication
{
    internal class Authentication
    {

        public Authentication(Student student)
        {
            MyStudent = student;
        }
        public Student MyStudent { get; set; }

        #region Login Method
        public bool loginMethod(string _userName, string _password, string _email)
        {
            return MyStudent.UserName == _userName && MyStudent.Password == _password && MyStudent.Email == _email;
        }

        public bool loginMethod(string _userName, string _password)
        {

            if (MyStudent.UserName == _userName && MyStudent.Password == _password) return true;
            return false;
        }

        public bool loginMethod(uint _id, string _password)
        {
            return MyStudent.ID == _id && MyStudent.Password == _password;
        }

        public bool loginMethod(string _email, uint _id)
        {
            return MyStudent.ID == _id && MyStudent.Email == _email;
        }
        #endregion

        #region Forget Password
        public string forgetPassword(string _username)
        {
            if (MyStudent.UserName == _username)
            {
                return $"{MyStudent.Password}";
            }
            else
            {
                return "User not Found!";
            }
        }

        public string forgetPassword(string _useremail, uint _id)
        {
            if (MyStudent.Email == _useremail && MyStudent.ID == _id)
            {
                return $"{MyStudent.Password}";
            }
            else
            {
                return "User not Found!";
            }
        }

        public string forgetPassword(uint _id)
        {
            if (MyStudent.ID == _id)
            {
                return $"{MyStudent.Password}";
            }
            else
            {
                return "User not Found!";
            }
        }
        #endregion

        #region Reset Password
        public bool resetPassword(uint _id, string _oldPassword, string _newPassword)
        {
            if (MyStudent.ID == _id && MyStudent.Password == _newPassword)
            {
                MyStudent.Password = _newPassword;
                return true;
            }
            return false;
        }


        public bool resetPassword(string _useremail, string _oldPassword, string _newPassword)
        {
            if (MyStudent.Email == _useremail && MyStudent.Password == _oldPassword)
            {
                MyStudent.Password = _newPassword;
                return true;
            }
            return false;
        }


        public bool resetPassword(uint _id, string _useremail, string _oldPassword, string _newPassword)
        {
            if (MyStudent.ID == _id && MyStudent.Email == _useremail && MyStudent.Password == _newPassword)
            {
                MyStudent.Password = _newPassword;
                return true;
            }
            return false;
        }
        #endregion
    }
}
