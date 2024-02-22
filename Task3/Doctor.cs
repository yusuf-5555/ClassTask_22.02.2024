public class Doctor
{
    string _fullName;
    string _specialty;
    int _experience;
    public void TreatPatient(string patientName)
    {
        System.Console.WriteLine($"{_fullName}, {_specialty}, лечит пациента по имени {patientName}");
    }
    public void PerformMedicalExamination(string patientName)
    {
        System.Console.WriteLine($"{_fullName} проводит медицинское обследование для пациента по имени {patientName}");
    }
    public void PrescribeMedication(string patientName, string medication)
    {
        System.Console.WriteLine($"{_fullName} назначает {medication} пациенту по имени {patientName}");
    }
    public void SetExperience(int years)
    {
        _experience = years;
    }
    public int GetExperience()
    {
        return _experience;
    }
    public Doctor()
    {

    }
    public Doctor(string fullName, string speciality)
    {
         _fullName = fullName;
        _specialty = speciality;
        System.Console.WriteLine("Doctor's Name: " + _fullName);
        System.Console.WriteLine("Medical Specialty: " + _specialty);
    }
  public Doctor(string fullName, string speciality, int experience)
    {
        _fullName = fullName;
        _specialty = speciality;
        _experience = experience;
    }
}