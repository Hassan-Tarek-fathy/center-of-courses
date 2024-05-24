CREATE TABLE department (
  dnumber INT PRIMARY KEY,
  name VARCHAR(255),
  manager VARCHAR(255),
  security VARCHAR(255),
  Trainers VARCHAR(255),
  maintenance VARCHAR(255)
);
CREATE TABLE employee (
  id INT PRIMARY KEY,
  fname VARCHAR(255),
  lname VARCHAR(255),
  salary DECIMAL(10,2),
  age INT,
  phone VARCHAR(255),
  city VARCHAR(255),
  street VARCHAR(255),
  department_id INT,
  FOREIGN KEY (department_id) REFERENCES department(dnumber)
);
CREATE TABLE branches (
  id INT PRIMARY KEY,
  Fname VARCHAR(255),
  Eservice VARCHAR(255),
  street VARCHAR(255),
  city VARCHAR(255),
  department_id INT,
  employee_id INT,
  FOREIGN KEY (department_id) REFERENCES department(dnumber),
  FOREIGN KEY (employee_id) REFERENCES employee(id)
);
CREATE TABLE courses (
  id INT PRIMARY KEY,
  name VARCHAR(255),
  technology VARCHAR(255),
  career VARCHAR(255) ,
  freelance VARCHAR(255) ,
  employee_id INT,
  branch_id INT,
  FOREIGN KEY (employee_id) REFERENCES employee(id),
  FOREIGN KEY (branch_id) REFERENCES branches(id)
);
CREATE TABLE service (
  id INT PRIMARY KEY,
  hall_reservation VARCHAR(255),
  registration VARCHAR(255),
  wi_fi VARCHAR(255),
  employee_id INT,
  branch_id INT,
  FOREIGN KEY (employee_id) REFERENCES employee(id),
  FOREIGN KEY (branch_id) REFERENCES branches(id)
);
CREATE TABLE trained (
  id INT PRIMARY KEY,
  name VARCHAR(50),
  age INT,
  address VARCHAR(100),
  specialization VARCHAR(50),
  employee_id INT,
  department_id INT,
  course_id INT,
  branch_id INT,
  FOREIGN KEY (employee_id) REFERENCES employee(id),
  FOREIGN KEY (department_id) REFERENCES department(dnumber),
  FOREIGN KEY (course_id) REFERENCES courses(id),
  FOREIGN KEY (branch_id) REFERENCES branches(id)
);
CREATE TABLE student (
  id INT NOT NULL PRIMARY KEY,
  name VARCHAR(255) NOT NULL,
  address VARCHAR(255),
  college VARCHAR(255) NOT NULL,
  specialization VARCHAR(255) NOT NULL
);
  