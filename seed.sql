CREATE TABLE employee (
  id UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
  first_name NVARCHAR(15) NOT NULL,
  last_name NVARCHAR(15) NOT NULL,
  insurance NVARCHAR(20),
  city NVARCHAR(20)
);

CREATE TABLE position (
  id UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
  name NVARCHAR(20) NOT NULL
);

CREATE TABLE position_employee (
  position_id UNIQUEIDENTIFIER NOT NULL,
  employee_id UNIQUEIDENTIFIER NOT NULL,
  PRIMARY KEY (position_id, employee_id),
  FOREIGN KEY (position_id) REFERENCES position(id),
  FOREIGN KEY (employee_id) REFERENCES employee(id)
);