namespace EntityFramework.Model
{
    public class initData
    {
        public static void GenData(SchoolDbContext db)
        {
            db.Database.EnsureCreated();
            if (db.Customer.Any())
            {
                //return;
            }
           /* customer cs = new customer();
            cs.name1 = "chanachai";
            cs.name2 = "benmat";
            cs.sex = "M";
            cs.age = 20;
            db.Customer.Add(cs);
            db.SaveChanges();
                
            customer cs2 = new customer();
            cs2.name1 = "patcharaphon";
            cs2.name2 = "Lertsitham";
            cs2.sex = "M";
            cs2.age = 40;
            db.Customer.Add(cs2);
            db.SaveChanges();
                
            customer cs3 = new customer();
            cs3.name1 = "pongsakorn";
            cs3.name2 = "nakwan";
            cs3.sex = "F";
            cs3.age = 18;
            db.Customer.Add(cs3);
            db.SaveChanges();

            customer cs4 = new customer();
            cs4.name1 = "pongsakorn";
            cs4.name2 = "nakwan";
            cs4.sex = "F";
            cs4.age = 18;
            db.Customer.Add(cs4);
            db.SaveChanges();
                
            customer cs5 = new customer();
            cs5.name1 = "peerasit";
            cs5.name2 = "chardkratok";
            cs5.sex = "F";
            cs5.age = 35;
            db.Customer.Add(cs5);
            db.SaveChanges();*/

            orderh orh = new orderh();
            orh.doc_no = "a112";
            orh.doc_date = new DateTime(2022,1,1);
            orh.amount = 299;
            orh.vat = 20.93;
            orh.net_amount = 319.93;
            orh.custumerid = 1;
            db.Orderh.Add(orh);
            db.SaveChanges();

            orderh orh2 = new orderh();
            orh2.doc_no = "a113";
            orh2.doc_date = new DateTime(2022, 01, 02);
            orh2.amount = 400;
            orh2.vat = 28;
            orh2.net_amount = 428;
            orh2.custumerid = 2;
            db.Orderh.Add(orh2);
            db.SaveChanges();

            orderh orh3 = new orderh();
            orh3.doc_no = "a114";
            orh3.doc_date = new DateTime(2022, 01, 03);
            orh3.amount = 420;
            orh3.vat = 29.4;
            orh3.net_amount = 449.5;
            orh3.custumerid = 3;
            db.Orderh.Add(orh3);
            db.SaveChanges();
            
        }
    }
}
