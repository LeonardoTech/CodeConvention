using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.IO;

namespace ParseLib
{
    public class CPlusPlusProvider : CodeDomProvider
    {

        //public override ICodeCompiler CreateCompiler()
        //{
        //    throw new Exception("The method or operation is not implemented.");
        //}

        public override ICodeGenerator CreateGenerator()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override void GenerateCodeFromCompileUnit(CodeCompileUnit compileUnit, TextWriter writer, CodeGeneratorOptions options)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override void GenerateCodeFromExpression(CodeExpression expression, TextWriter writer, CodeGeneratorOptions options)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override void GenerateCodeFromMember(CodeTypeMember member, TextWriter writer, CodeGeneratorOptions options)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override void GenerateCodeFromNamespace(CodeNamespace codeNamespace, TextWriter writer, CodeGeneratorOptions options)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override void GenerateCodeFromStatement(CodeStatement statement, TextWriter writer, CodeGeneratorOptions options)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override void GenerateCodeFromType(CodeTypeDeclaration codeType, TextWriter writer, CodeGeneratorOptions options)
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }
}
