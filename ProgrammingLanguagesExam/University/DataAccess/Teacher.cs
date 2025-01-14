﻿namespace University.DataAccess;

public class Teacher
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Age { get; set; }

    public List<Skill> Skills { get; set; }
}