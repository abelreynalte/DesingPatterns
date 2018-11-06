using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype2
{
    public class UserAccount: ICloneable
    {
        private String userName;
        private String password;
        private String fname;
        private String lname;
        private List<Permission> permissions = new List<Permission>();

        public void setUserName(String uName)
        {
            userName = uName;
        }

        public String getUserName()
        {
            return userName;
        }

        public void setPassword(String pwd)
        {
            password = pwd;
        }

        public String getPassword()
        {
            return password;
        }

        public void setFName(String name)
        {
            fname = name;
        }

        public String getFName()
        {
            return fname;
        }

        public void setLName(String name)
        {
            lname = name;
        }

        public String getLName()
        {
            return lname;
        }

        public void setPermissions(List<Permission> rights)
        {
            permissions = rights;
        }

        public List<Permission> getPermissions()
        {
            return permissions;
        }

        public void addPermission(Permission p)
        {
            permissions.Add(p);
        }

        public Object Clone()
        {
            //Shallow Copy
            try
            {
                return MemberwiseClone();
            }
            catch (NotSupportedException e)
            {
                return null;
            }

            //Deep Copy
            /*
            UserAccount account = new UserAccount();
            account.setUserName(this.getUserName());
            account.setPassword(this.getPassword());
            account.setFName(this.getFName());
            account.setLName(this.getLName());
            Vector<Permission> permissions = new Vector<Permission>();
            for (int i=0; i<permissions.size(); i++) {
                Permission permission = (Permission) permissions.elementAt(i).clone();
                permissions.add(permission);
            }
            account.setPermissions(permissions);
            return account;
            */
        }

        public String toString()
        {
            String str = "User: " + getUserName() + "\n" + " Permissions : \n";
            for (int i = 0; i < permissions.Count; i++)
            {
                str = str + (Permission)permissions[i] + "\n";
            }
            return str;
        }
    }
}
