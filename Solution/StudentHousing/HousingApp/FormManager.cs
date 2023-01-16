using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingApp
{
    public class FormManager
    {
        // one main building object
        public static Building building = new Building();

        // the current user (student)
        public static Student Student { get;  set; }

        // the current user (admin)
        public static Admin admin { get; set; }

        private static LoginForm _loginForm;
        private static SignUpForm _signUpForm;
        private static MenuForm _menuForm;
        private static TaskForm _taskForm;
        private static ComplaintsForm _complaintsForm;
        private static RulesForm _rulesForm;
        private static AnnouncementForm _announcementForm;
        private static PaymentForm _paymentForm;
        private static ProfileForm _profileForm;

        //adminform
        private static AdminForm _adminForm;

        public static LoginForm loginForm
        {
            get
            {
                if (_loginForm == null)
                {
                    _loginForm = new LoginForm(building);
                    
                }
                return _loginForm;
            }
        }
        public static SignUpForm signUpForm
        {
            get
            {
                if (_signUpForm == null)
                {
                    _signUpForm = new SignUpForm(building);
                }
                return _signUpForm;
            }
            set 
            {
                _signUpForm = value; 
            }
        }
        public static MenuForm MenuForm
        {
            get
            {
                if(_menuForm == null)
                {
                    _menuForm = new MenuForm(building, Student);
                }
                return _menuForm;
            }
            set
            {
                _menuForm = value;
            }
        }
        public static TaskForm TaskForm
        {
            get
            {
                if(_taskForm == null)
                {
                    _taskForm = new TaskForm(building,Student);
                }
                return _taskForm;
            }
            set
            {
                _taskForm = value;
            }
        }
        public static ComplaintsForm complaintsForm
        {
            get
            {
                if (_complaintsForm == null)
                {
                    _complaintsForm = new ComplaintsForm(building,Student);
                }
                return _complaintsForm;
            }
            set
            {
                _complaintsForm = value;
            }
        }
        public static RulesForm rulesForm
        {
            get
            {
                if (_rulesForm == null)
                {
                    _rulesForm = new RulesForm(building);
                }
                return _rulesForm;
            }
            set
            {
                _rulesForm = value;
            }
        }
        public static AnnouncementForm announcementForm
        {
            get
            {
                if (_announcementForm == null)
                {
                    _announcementForm = new AnnouncementForm(building,Student);
                }
                return _announcementForm;
            }
            set
            {
                _announcementForm = value;
            }
        }
        public static PaymentForm paymentForm
        {
            get
            {
                if (_paymentForm == null)
                {
                    _paymentForm = new PaymentForm(building, Student);
                }
                return _paymentForm;
            }
            set
            {
                _paymentForm = value;
            }
        }
        public static ProfileForm profileForm
        {
            get
            {
                if (_profileForm == null)
                {
                    _profileForm = new ProfileForm(building,Student);
                }
                return _profileForm;
            }
            set
            {
                _profileForm = value;
            }
        }

        public static AdminForm adminForm
        { 
            get
            {
                if (_adminForm == null)
                {
                    _adminForm = new AdminForm(building,admin);
                }
                return _adminForm;
            }
            set
            {
                _adminForm = value;
            }
        }

            
    }
}
