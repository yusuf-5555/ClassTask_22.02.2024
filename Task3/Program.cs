var doctor = new Doctor("Yusuf Rahmon","Xirurg");
doctor.SetExperience(5);
System.Console.WriteLine("Years of experience: " + doctor.GetExperience());
doctor.TreatPatient("Behruz");
doctor.PerformMedicalExamination("Yusuf");
doctor.PrescribeMedication("Said", "Kurut");

