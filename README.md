<p align="center">
   <img src="https://github.com/Topman-14/ScholarPro/assets/98329531/e56999c6-40e7-43ab-aae1-31b95cf0bc63" alt="ScholarPro logo"  />
</p>

# ScholarPro - Windows LMS Build

[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![Visual Studio](https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visual%20studio&logoColor=white)](https://visualstudio.microsoft.com/)
[![MySQL](https://img.shields.io/badge/MySQL-005C84?style=for-the-badge&logo=mysql&logoColor=white)](https://www.mysql.com/)

ScholarPro is a comprehensive Learning Management System (LMS) I developed using C# in Visual Studio, specifically designed for Windows environments. 
This system aims to provide an efficient and user-friendly platform for educational institutions, instructors, and students to streamline the learning process.

## ScreenShots
<p align="center">
   
### Login
   ![schproLogin](https://github.com/Topman-14/ScholarPro/assets/98329531/4f625c39-a5a1-4222-b10a-713b4ef13503)

### Dashboard
   ![schproDashboard](https://github.com/Topman-14/ScholarPro/assets/98329531/d86c4158-e8d3-4f90-abee-724534be7f82)

### View Course Details
![viewCourse](https://github.com/Topman-14/ScholarPro/assets/98329531/ba13c942-e5f1-4cd7-afb5-08dd1c6812af)

</p>

## Features

- **User-Friendly Interface:** ScholarPro boasts an intuitive and accessible user interface, ensuring a seamless experience for both students and administrators.

- **Role-Based Access Control:** The LMS supports two distinct access roles:
    - **Admin:** Administrators have access to features such as course management, and overall system configuration.
    - **Student:** Students can enroll in courses, view learning materials, and track their progress.

- **MySql Database Integration:** ScholarPro leverages a MySql database for efficient data management, ensuring reliability and scalability.


## Prerequisites
- [Visual Studio 2019 or later](https://visualstudio.microsoft.com/) installed on your Windows machine.
- .NET Core 3.1 or later
- [XAMPP](https://www.apachefriends.org/) installed locally.

## Steps to Set Up Locally

1. **Clone the Repository:**
    ```bash
    git clone https://github.com/Topman-14/ScholarPro.git
    cd ScholarPro
    ```

2. **Database Setup:**
    - Create a new database in MySql for ScholarPro.
    - Execute the SQL script provided in `database_setup.sql` to create the necessary tables and seed initial data.

3. **Configuration:**
    - Open the `app.config` file in the project.
    - Update the database connection string with your MySql server details.

4. **Open in Visual Studio:**
    - Open the `ScholarPro.sln` solution file in Visual Studio.

5. **Build and Run:**
    - Build the solution in Visual Studio.
    - Run the application.

6. **Access Roles:**
    - **Admin:**
        - Username: admin
        - Password: admin123

    - **Student:**
        - Username: student
        - Password: student123

7. **Explore the LMS:**
    - Open your web browser and go to `http://localhost:port` (replace `port` with the port used by your Visual Studio instance).

8. **Start Learning:**
    - Log in with the provided admin or student credentials.
    - Explore the features and functionalities of ScholarPro.

## Contributing

If you'd like to contribute to ScholarPro, please follow our [Contribution Guidelines](CONTRIBUTING.md).

## License

This project is licensed under the [MIT License](LICENSE).
