using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WinformFamilyTree.TreeClasses
{
    public class MemberClass
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfDeath { get; set; }
        public string PlaceOfOrigin { get; set; }
        public string Biography { get; set; }
        public byte[] proFilePicture { get; set; }

        // Connect to the database
        static string myConnectionString = ConfigurationManager.ConnectionStrings["connstrngMember"].ConnectionString;

        // Function for Selecting data from Database
        public DataTable Select()
        {
            // Step 1: Database connection
            SqlConnection conn = new SqlConnection(myConnectionString);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                // Creating SQL Command using sql and connection
                string sql = "SELECT * FROM MEMBER";
                SqlCommand cmd = new SqlCommand(sql, conn);
                // Creating Adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }
            return dt;
        }

        public MemberClass SelectMember(int memberID)
        {
            SqlConnection conn = new SqlConnection(myConnectionString);
            DataTable dt = new DataTable();
            MemberClass member = new MemberClass();
            try
            {
                conn.Open();
                // Creating SQL Command using sql and connection
                string sql = "SELECT * FROM MEMBER WHERE MemberID = @MemberID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MemberID", memberID);
                // Creating Adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                member.ID = memberID;
                member.FirstName = dt.Rows[0].Field<string>(1);
                member.LastName = dt.Rows[0].Field<string>(2);
                member.DateOfBirth = dt.Rows[0].Field<DateTime>(3);
                member.Gender = dt.Rows[0].Field<string>(4);
                member.PlaceOfOrigin = dt.Rows[0].Field<string>(5);
                member.Biography = dt.Rows[0].Field<string>(7);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }
            return member;
        }
        // Function for inserting Data into database
        public bool Insert(MemberClass c)
        {
            // Creating a default return type and setting its value to false
            bool isSuccess = false;
            // Step 1: Database connection
            SqlConnection conn = new SqlConnection(myConnectionString);
            try
            {
                conn.Open();
                // Creating SQL Command using sql and conn
                string sql = "INSERT INTO MEMBER (FirstName, LastName, Gender, DateOfBirth, PlaceOfOrigin, MemberProfilePicture) VALUES(@FirstName, @LastName, @Gender, @DateOfBirth, @PlaceOfOrigin, @MemberProfilePicture)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("@DateOfBirth", c.DateOfBirth);
                cmd.Parameters.AddWithValue("@PlaceOfOrigin", c.PlaceOfOrigin);
                cmd.Parameters.AddWithValue("@MemberProfilePicture", c.proFilePicture);
                int rows = cmd.ExecuteNonQuery();
                // If the query run sucessfully, the value of rows will be greater than 0 else its value will be 0
                if (rows > 0) { isSuccess = true; }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }
            return isSuccess;
        }

        //Insert spouse
        public bool InsertSpouseRel(int ID1, int ID2)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myConnectionString);
            try
            {
                conn.Open();
                // Creating SQL Command using sql and conn
                string sql = "INSERT INTO RELATIONSHIP_SPOUSE (MemberID1, MemberID2) VALUES (@ID1, @ID2)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID1", ID1);
                cmd.Parameters.AddWithValue("@ID2", ID2);
                int rows = cmd.ExecuteNonQuery();
                // If the query run sucessfully, the value of rows will be greater than 0 else its value will be 0
                if (rows > 0) { isSuccess = true; }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }
            return isSuccess;
        }

        // insert child
        public bool InsertParentChildRel(int childID, int spouseID)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myConnectionString);
            try
            {
                conn.Open();
                // Creating SQL Command using sql and conn
                string sql = "INSERT INTO RELATIONSHIP_PARENT_CHILD (ChildID, ParentID) VALUES (@childID, @ParentID)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ChildID", childID);
                cmd.Parameters.AddWithValue("@ParentID", spouseID);
                int rows = cmd.ExecuteNonQuery();
                // If the query run sucessfully, the value of rows will be greater than 0 else its value will be 0
                if (rows > 0) { isSuccess = true; }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }
            return isSuccess;
        }

        // Function for Update data to database
        public bool Update(MemberClass c)
        {
            // Creating a default return type and setting its value to false
            bool isSuccess = false;
            // Step 1: Database connection
            SqlConnection conn = new SqlConnection(myConnectionString);
            try
            {
                conn.Open();
                // Creating SQL Command using sql and conn

                string sql = "UPDATE MEMBER SET FirstName = @FirstName, LastName = @LastName, DateOfBirth = @DateOfBirth, Gender = @Gender, PlaceOfOrigin = @PlaceOfOrigin, MemberProfilePicture = @MemberProfilePicture WHERE MemberID = @MemberID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("@DateOfBirth", c.DateOfBirth);
                cmd.Parameters.AddWithValue("@PlaceOfOrigin", c.PlaceOfOrigin);
                cmd.Parameters.AddWithValue("@Biography", c.Biography);
                cmd.Parameters.AddWithValue("@MemberID", c.ID);
                cmd.Parameters.AddWithValue("@MemberProfilePicture", c.proFilePicture);
                int rows = cmd.ExecuteNonQuery();
                // If the query run sucessfully, the value of rows will be greater than 0 else its value will be 0
                if (rows > 0) { isSuccess = true; }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }
            return isSuccess;
        }
        // Function for delete data to database
        public bool Delete(int memberID)
        {
            // Creating a default return type and setting its value to false
            bool isSuccess = false;
            // Step 1: Database connection
            SqlConnection conn = new SqlConnection(myConnectionString);
            try
            {
                conn.Open();
                // Creating SQL Command using sql and conn
                string sql = "DELETE FROM MEMBER WHERE MemberID = @ID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", memberID);
                int rows = cmd.ExecuteNonQuery();
                // If the query run sucessfully, the value of rows will be greater than 0 else its value will be 0
                if (rows > 0) { isSuccess = true; }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }
            return isSuccess;
        }

        public int numMember()
        {
            SqlConnection conn = new SqlConnection(myConnectionString);
            int count = 0;
            DataTable dt = new DataTable();
            try
            {
                conn.Open();

                string sql = "SELECT COUNT(*) FROM MEMBER ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                int rows = cmd.ExecuteNonQuery();
                adapter.Fill(dt);
                count = dt.Rows[0].Field<int>(0);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }
            
            return count;
        }

        public int getMemberID(MemberClass member)
        {
            SqlConnection conn = new SqlConnection(myConnectionString);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();

                string sql = "SELECT MemberID FROM MEMBER WHERE FirstName = @FirstName AND LastName = @LastName";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@FirstName", member.FirstName);
                cmd.Parameters.AddWithValue("@LastName",member.LastName);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                int rows = cmd.ExecuteNonQuery();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }
            // if the query is empty, dt is have no rows and opposite
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0].Field<int>(0);
            }
            else { return -1; }
        }

        public int getMaxMemberID()
        {
            SqlConnection conn = new SqlConnection(myConnectionString);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();

                string sql = "SELECT MAX(MemberID) FROM MEMBER";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                int rows = cmd.ExecuteNonQuery();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }
            // if the query is empty, dt is have no rows and opposite
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0].Field<int>(0);
            }
            else { return -1; }
        }

        public int getSpouseID(int memberID)
        {
            SqlConnection conn = new SqlConnection(myConnectionString);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();

                string sql = "SELECT SpouseID FROM RELATIONSHIP_SPOUSE WHERE MemberID1 = @MemberID OR MemberID2 = @MemberID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MemberID", memberID);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                int rows = cmd.ExecuteNonQuery();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }
            // if the query is empty, dt is have no rows and opposite
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0].Field<int>(0);
            }
            else { return -1; }

        }
        //public DataTable FindFromName(string queryStr)
        //{
        //    // Step 1: Database connection
        //    SqlConnection conn = new SqlConnection(myConnectionString);
        //    DataTable dt = new DataTable();
        //    try
        //    {
        //        conn.Open();
        //        // Creating SQL Command using sql and connection
        //        string sql = "SELECT * FROM MEMBER WHERE CONCAT(LastName,' ',FirstName) LIKE '%" + queryStr + "%'";
        //        SqlCommand cmd = new SqlCommand(sql, conn);
        //        // Creating Adapter using cmd
        //        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //        adapter.Fill(dt);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    finally { conn.Close(); }
        //    return dt;
        //}



        public int getParentID(int childID)
        {
            SqlConnection conn = new SqlConnection(myConnectionString);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();

                string sql = "SELECT ParentID FROM RELATIONSHIP_PARENT_CHiLD WHERE ChildID = @ChildID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ChildID", childID);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                int rows = cmd.ExecuteNonQuery();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }
            // if the query is empty, dt is have no rows and opposite
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0].Field<int>(0);
            }
            else { return -1; }

        }

        public int getChildID(int parentID, ref int[] array, ref int arrayIndex)
        {
            SqlConnection conn = new SqlConnection(myConnectionString);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();

                string sql = "SELECT ChildID FROM RELATIONSHIP_PARENT_CHILD WHERE ParentID = @ParentID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ParentID", parentID);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                int rows = cmd.ExecuteNonQuery();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }
            
            // if the query is empty, dt is have no rows and opposite
            if (dt.Rows.Count > 0)
            {
                for(int i=0; i<dt.Rows.Count; i++)
                {
                    array[arrayIndex] = dt.Rows[i].Field<int>(0);
                    arrayIndex++;
                }
                return dt.Rows.Count;
            }
            else { return -1; }

        }

        public int getMemberPartner(int spouseID, int memberID)
        {
            SqlConnection conn = new SqlConnection(myConnectionString);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();

                string sql = "SELECT MemberID1, MemberID2 FROM RELATIONSHIP_SPOUSE WHERE SpouseID = @SpouseID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@SpouseID", spouseID);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                int rows = cmd.ExecuteNonQuery();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }

            // if the query is empty, dt is have no rows and opposite
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0].Field<int>(0) == memberID)
                {
                    return dt.Rows[0].Field<int>(1);
                }
                return dt.Rows[0].Field<int>(0);
            }
            else { return -1; }

        }




        public bool delSpouse(int spouseID)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myConnectionString);
            try
            {
                conn.Open();
                string sql = "DELETE FROM RELATIONSHIP_SPOUSE WHERE SpouseID = @SpouseID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@SpouseID", spouseID);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0) { isSuccess = true; }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }
            return isSuccess;
        }

        public bool delParent(int childID)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myConnectionString);
            try
            {
                conn.Open();
                string sql = "DELETE FROM RELATIONSHIP_PARENT_CHILD WHERE ChildID = @ChildID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ChildID", childID);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0) { isSuccess = true; }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }
            return isSuccess;
        }

        public bool delChild(int parentID)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myConnectionString);
            try
            {
                conn.Open();
                string sql = "DELETE FROM RELATIONSHIP_PARENT_CHILD WHERE ParentID = @ParentID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ParentID", parentID);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0) { isSuccess = true; }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }
            return isSuccess;
        }

        public bool isMemberID(int ID)
        {
            SqlConnection conn = new SqlConnection(myConnectionString);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();

                string sql = "SELECT MemberID FROM MEMBER WHERE MemberID = @MemberID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MemberID", ID);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                int rows = cmd.ExecuteNonQuery();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }
            // if the query is empty, dt is have no rows and opposite
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        public DataTable FindFromName(string queryStr)
        {
            // Step 1: Database connection
            SqlConnection conn = new SqlConnection(myConnectionString);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                // Creating SQL Command using sql and connection
                string sql = "SELECT * FROM MEMBER WHERE CONCAT(LastName,' ',FirstName) LIKE '%" + queryStr  + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                // Creating Adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }
            return dt;
        }
        
        public DataTable FindFromName_ID(string queryStr)
        {
            // Step 1: Database connection
            SqlConnection conn = new SqlConnection(myConnectionString);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                // Creating SQL Command using sql and connection
                string sql = "SELECT MemberID, CONCAT(LastName,' ',FirstName) AS MemberName FROM MEMBER WHERE CONCAT(LastName,' ',FirstName) LIKE '%" + queryStr + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                // Creating Adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }
            return dt;
        }
    }
}
