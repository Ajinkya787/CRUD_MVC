namespace CRUD_MVC
{
    public class ProductDal
    {
        sqlConnection con;
        sqlCommon cmd;
        sqlDataReader dr;

        public ProductDal()
        {
            con = new sqlConnection(StartUp.ConnectionString);
        }
        public List<Product> GetAllProduct()
        {
            string qry = "select * from Product";
            cmd = new sqlCommand(qry, con);
            con.Open();
            dr=cmd.ExecuteReader
            if (dr.HasRow)
            {
                while (dr.Read())
                {
                    Product product = new Product();
                    product.Name = dr["Name"].ToString();
                    Product.Id = Convert.ToInt32(dr["Id"]);
                    Product 
                    int id = (int)dr["id"];
                    Console.WriteLine(id);
              }
                //close the connection 
                con.close()

            }
        }
       }
}