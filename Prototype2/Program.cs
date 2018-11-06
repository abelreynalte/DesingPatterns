using System;
using System.Collections.Generic;
using System.IO;

namespace Prototype2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Permission> supervisorPermissions = getPermissionsFromFile("supervisor.txt");
            UserAccount supervisor = new UserAccount();
            supervisor.setPermissions(supervisorPermissions);

            List<Permission> accountRepPermissions = getPermissionsFromFile("accountrep.txt");
            UserAccount accountRep = new UserAccount();
            accountRep.setPermissions(accountRepPermissions);

            AccountPrototypeFactory factory = new AccountPrototypeFactory(supervisor, accountRep);

            UserAccount newSupervisor = factory.getSupervisor();
            newSupervisor.setUserName("PKuchana");
            newSupervisor.setPassword("Everest");
            //System.out.println(newSupervisor);
            Console.WriteLine(newSupervisor);

            UserAccount anotherSupervisor = factory.getSupervisor();
            anotherSupervisor.setUserName("SKuchana");
            anotherSupervisor.setPassword("Everest");
            //System.out.println(anotherSupervisor);
            Console.WriteLine(anotherSupervisor);

            UserAccount newAccountRep = factory.getAccountRep();
            newAccountRep.setUserName("VKuchana");
            newAccountRep.setPassword("Vishal");
            //System.out.println(newAccountRep);
            Console.WriteLine(newAccountRep);
            Console.ReadKey();
        }
        public static List<Permission> getPermissionsFromFile(String fileName)
        {
            List<Permission> permissions = new List<Permission>();
            String inputLine;
            try {
                //    URL path = Client.class.getResource(fileName);
                //    File inFile = new File(path.toURI());
                //    BufferedReader br = new BufferedReader(
                //                          new InputStreamReader(
                //                            new FileInputStream(inFile)));

                //  while ((inputLine = br.readLine()) != null) {
                //    StringTokenizer st = new StringTokenizer(inputLine, ",");
                //    String resource = st.nextToken();
                //    String permission = st.nextToken();
                //    permissions.addElement(new Permission(resource, permission));
                //  }
                //br.close();
                //URL path = typeof(Program).getr(fileName);
                //File inFile = new File();
                StreamReader br = new StreamReader(new FileStream(fileName, FileMode.Open, FileAccess.Read));

                while (!string.ReferenceEquals((inputLine = br.ReadLine()), null))
                {
                    String[] st = inputLine.Split(",");
                    string resource = st[1];
                    string permission = st[2];
                    permissions.Add(new Permission(resource, permission));
                }
                br.Close();

            }
            catch (FileNotFoundException ex) {
            }
            catch (IOException ex) {
            }
            return permissions;
        }
    }
}
