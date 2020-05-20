using System;
using System.Reflection;

namespace TestFramework
{
    [AttributeUsage(AttributeTargets.Class)]
    public class NTestClassAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Method)]
    public class NTestMethodAttribute : Attribute
    {
    }

    public class TestRunner
    {
        public static void Run()
        {
            Type[] types = Assembly.GetCallingAssembly().GetTypes();
            Attribute[] attrs;
            foreach (Type t in types)
            {
                attrs = Attribute.GetCustomAttributes(t);

                foreach (Attribute attr in attrs)
                {
                    if (attr is NTestClassAttribute)
                    {
                        NTestClassAttribute a = (NTestClassAttribute)attr;

                        MethodInfo[] methods = t.GetMethods();
                        foreach (MethodInfo methodInfo in methods)
                        {
                            Attribute attributes = methodInfo.GetCustomAttribute(typeof(NTestMethodAttribute), false);

                            var attribute = (NTestMethodAttribute)attributes;

                            if (attribute is NTestMethodAttribute)
                            {
                                object obj = Activator.CreateInstance(t);
                                object result = methodInfo.Invoke(obj, null);
                            }
                        }
                    }
                }
            }
        }
    }

    public class Assert<T> where T : IComparable<T>
    {
        public static bool AreEqual(T expected, T result)
        {
            if (expected.CompareTo(result) == 0)
                return true;
            else return false;
        }

        public static bool IsTrue(bool condition)
        {
            if (condition)
                return true;
            else
                return false;
        }

        public static bool IsFalse(bool condition)
        {
            if (condition)
                return false;
            else
                return true;
        }
    }
}