using System;
using System.IO;
using System.Collections.Generic;

public sealed class ConfigurationManager
{
    private static readonly ConfigurationManager instance = new ConfigurationManager();
    private Dictionary<string, string> configSettings;

    static ConfigurationManager() { }

    private ConfigurationManager()
    {
        // Load configuration settings from a file
        configSettings = new Dictionary<string, string>();
        using (var reader = new StreamReader("E:\\Curso Quark\\Design Patterns\\Decorator - Robots\\config.txt"))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split('=');
                configSettings.Add(values[0], values[1]);
            }
        }
    }

    public static ConfigurationManager Instance
    {
        get
        {
            return instance;
        }
    }

    public int GetRobotHealth()
    {
        string value;
        if (configSettings.TryGetValue("health", out value))
        {
            return int.Parse(value);
        }
        throw new KeyNotFoundException("health setting not found.");
    }

    public int GetRobotAttack()
    {
        string value;
        if (configSettings.TryGetValue("attack", out value))
        {
            return int.Parse(value);
        }
        throw new KeyNotFoundException("MaxRobotHealth setting not found.");
    }

    public int GetRobotPrice()
    {
        string value;
        if (configSettings.TryGetValue("price", out value))
        {
            return int.Parse(value);
        }
        throw new KeyNotFoundException("RobotAttackStrength setting not found.");
    }
}
