﻿using UniversityAPI.Application.DTOs;
using UniversityAPI.Core.Models;

namespace UniversityAPI.Core.Interface
{
	public interface IDoctorRepository
	{
		Task<Doctor> GetDoctorByEmailAsync(string email);
		Task<List<CourseDTO>> GetCoursesForDoctorsAsync(string email);
		Task<IEnumerable<StudentInfoDTO>> GetStudentsByCourseAsync(string courseId);
		Task<StudentDegreeDto> GetStudentsDegreesForCourseAsync(string email, string courseId);
		Task<bool> EditStudentDegreesForDoctorAsync(string email, string courseId, StudentDegreeUpdateDTO studentDegreeDto);
	}
}