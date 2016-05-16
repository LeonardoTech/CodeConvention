using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.IO;

namespace ParseLib
{
    public class Class1
    {
        public static void Generate()
        {
            // namespace
            var ns = new CodeNamespace("bimWorld");
            ns.Comments.Add(new CodeCommentStatement()
            {
                Comment = new CodeComment()
                {
                    DocComment = true,
                    Text = "This is auto generate code. Modifications to the code might result breaking changes.",
                }
            });

            // class
            var classCode = new CodeTypeDeclaration("Test");
            classCode.IsClass = true;

            classCode.TypeAttributes = System.Reflection.TypeAttributes.Public;
            classCode.IsPartial = false;

            var property = new CodeMemberProperty
            {
                Attributes = MemberAttributes.Public | MemberAttributes.Final,
                Name = "TestProperty",
                Type = new CodeTypeReference(typeof(int)),
                HasGet = true,
                HasSet = true,
            };
            classCode.Members.Add(property);
            ns.Types.Add(classCode);

            // generate
            var options = new CodeGeneratorOptions()
            {
                IndentString = "    ",
                BracingStyle = "C",
                BlankLinesBetweenMembers = true,
            };

            using(var codeWriter = new StreamWriter(@"TestClass.h"){AutoFlush = true})
            {
                CodeDomProvider.CreateProvider("C++").GenerateCodeFromNamespace(ns, codeWriter, options);
            }
        }
    }
}
