﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Mobile_GetUpcomingMedicalTestsCountDL
/// </summary>
public class Mobile_GetUpcomingMedicalTestsCountDL
{
    public string Mobile_GetUpcomingMedicalTestsCount(int patientId)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("sp_Mobile_GetUpcomingMedicalTestsCount", conn);
        cmd.Parameters.Add("@patientId", patientId);
        cmd.CommandType = CommandType.StoredProcedure;
        DataSet ds = new DataSet();
        conn.Open();
        string medicalTestCount = (cmd.ExecuteScalar()).ToString();
        conn.Close();
        return medicalTestCount;
	}
}