﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BEL;
using System.Data;
using MySql.Data.MySqlClient;

namespace BAL
{
    public class Operations
    {
        public Dbconnection db = new Dbconnection();
        public Informations info = new Informations();
        //Here we declare the queries and do operations needed for the application

        public int insertUser(Informations info)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into registrationform VALUES('"+ info.firstname+ "', '" + info.lastname+ "','" + info.email + "','" + info.username + "','" + info.password + "','" + info.gender + "')";
            return db.ExeNonQuery(cmd);
        }
        public int insertMovie(Informations info)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = cmd.CommandText = "insert into movies VALUES('" + info.username + "', '" + info.title + "','" + info.raiting + "','" + info.genre + "','" + info.status+ "')";
            return db.ExeNonQuery(cmd);
        }
        public DataTable login(Informations info)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from registrationform where username='"+info.username+"' and password ='"+info.password+"'";
            return db.ExeReader(cmd);
            
        }
        public DataTable getMovies(Informations info)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from movies where user='" + info.username +"'";
            return db.ExeReader(cmd);

        }




    }
        
    }

       

       
    

