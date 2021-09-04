using DocumentFormat.OpenXml.ExtendedProperties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Tesis.Utilities
{
    public static class FileReader
    {
        public static void MakeScript()
        {
            var fileName = @"X:\src\Tesis\Utilities\Preguntas txt.txt";

            string text = File.ReadAllText(fileName);
            string[] lines = text.Split(Environment.NewLine);

            StringBuilder sentenceFile = new StringBuilder();

            sentenceFile.Append("DECLARE @lastId INT;" + Environment.NewLine);


            foreach (var line in lines)
            {

                string[] atributes = line.Split(';');

                sentenceFile.Append(@"INSERT INTO [dbo].[question]([questionName],[finalInfo],[CategoryType])VALUES(");

                sentenceFile.Append(atributes[0] + ",");
                sentenceFile.Append(atributes[5] + ",");
                sentenceFile.Append(atributes[6]);
                sentenceFile.Append(");" + Environment.NewLine);

                sentenceFile.Append("SET @lastId = (SELECT SCOPE_IDENTITY());" + Environment.NewLine);

                sentenceFile.Append(@"INSERT INTO [dbo].[answer]([questionID],[answerName],[isCorrect])VALUES(");
                sentenceFile.Append("@lastId, ");
                sentenceFile.Append(atributes[1] + ",");
                sentenceFile.Append("1);" + Environment.NewLine);

                sentenceFile.Append(@"INSERT INTO [dbo].[answer]([questionID],[answerName],[isCorrect])VALUES(");
                sentenceFile.Append("@lastId, ");
                sentenceFile.Append(atributes[2] + ",");
                sentenceFile.Append("0);" + Environment.NewLine);

                sentenceFile.Append(@"INSERT INTO [dbo].[answer]([questionID],[answerName],[isCorrect])VALUES(");
                sentenceFile.Append("@lastId, ");
                sentenceFile.Append(atributes[3] + ",");
                sentenceFile.Append("0);" + Environment.NewLine);

                sentenceFile.Append(@"INSERT INTO [dbo].[answer]([questionID],[answerName],[isCorrect])VALUES(");
                sentenceFile.Append("@lastId, ");
                sentenceFile.Append(atributes[4] + ",");
                sentenceFile.Append("0);" + Environment.NewLine);

            }

            File.WriteAllText(@"X:\src\Tesis\Utilities\result", sentenceFile.ToString());


        }

    }
}
