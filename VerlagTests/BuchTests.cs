using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Verlag;
using VerlagTests;

namespace VerlagTests
{
	[TestClass]
	public class BuchTests
	{
		[TestMethod]
		public void Buch_KannErstelltWerden()
		{
			//Arrange
			string autor = "J.K. Rowling";
			string titel = "Harry Potter und der Gefangene von Askaban";
			int auflage = 1;

			//Act 
			Buch b = new Buch(autor, titel, auflage);

			//Assert
			Assert.AreEqual(autor, b.Autor);
			Assert.AreEqual(titel, b.buchtitel);
			Assert.AreEqual(auflage, b.Auflage);
		}

		[TestMethod]
		public void Buch_KeineAuflageEntsprichtErsterAuflage()
		{
			//Arrange

			//Act 
			Buch b = new Buch("autor", "titel");

			//Assert
			Assert.AreEqual(1, b.Auflage);
		}

		[TestMethod]
		public void Autor_DarfVeraendertWerden()
		{
			//Arrange
			string autor = "Abdullah";
			string autorNeu = "Thomas";

			//Act
			Buch b = new Buch(autor, "titel");
			b.Autor = autorNeu;

			//Assert
			Assert.AreEqual(autorNeu, b.Autor);

		}

		[TestMethod]
		public void Auflage_DarfVeraendertWerden()
		{
			//Arrange
			int auflage = 15;
			int auflageNeu = 42;

			//Act
			Buch b = new Buch("autor", "titel", auflage);
			b.Auflage = auflageNeu;

			//Assert
			Assert.AreEqual(auflageNeu, b.Auflage);

		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void Buch_AuflageDarfNichtZuKleinSein()
		{
			//Arrange
			int auflage = 0;

			//Act
			Buch b = new Buch("autor", "titel", auflage);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void Auflage_DarfNichtZuKleinSein()
		{
			//Arrange
			Buch b = new Buch("autor", "titel");
			int auflageNeu = 0;

			//Act
			b.Auflage = auflageNeu;
        }
        //List<string> unerlaubteZeichen = new List<string> { "", "#", ";", "§", "%" };

        //[ExpectedException(typeof(ArgumentException))]
        //public void Autor_NurSinnvolleEingabenErlaubt(List<string> unerlaubteZeichen)
        //{
        //  foreach (var i in unerlaubteZeichen)
        //{
        //  //auf contains prüfen
        //if (.contains = i)
        //}
        //}
        // DataRow: https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest#add-more-features
        [TestMethod]
		[DataRow("")]
		[DataRow("#")]
		[DataRow(";")]
		[DataRow("§")]
		[DataRow("%")]
		[ExpectedException(typeof(ArgumentException))]
		public void Autor_NurSinnvolleEingabenErlaubt(string unerlaubtesZeichen)
		{
			string testName = "Daniel Listwan";

            Random rnd = new Random();
            Console.WriteLine(rnd.Next(1, testName.Length + 1));
			testName.Insert(Convert.ToInt32(rnd), unerlaubtesZeichen);



			
			Buch b = new Buch(unerlaubtesZeichen, "titel");
		}
	}
}
