CREATE DATABASE ELearningDb
GO
USE ELearningDb

GO
CREATE TABLE Account (
	acc_id INT PRIMARY KEY IDENTITY(1,1),
	fullname NVARCHAR(MAX) NOT NULL, 
	username NVARCHAR(MAX) NOT NULL, 
	email NVARCHAR(MAX) NOT NULL, 
	avatar NVARCHAR(MAX) NOT NULL, 
	user_password NVARCHAR(MAX) NOT NULL, 
	user_role INT NOT NULL DEFAULT 0, 
)

GO

CREATE TABLE Course (
	course_id INT PRIMARY KEY IDENTITY(1,1),
	course_name NVARCHAR(MAX) NOT NULL, 
	lecturer NVARCHAR(MAX) NOT NULL, 
	difficulty NVARCHAR(20) CHECK (difficulty IN ('Beginner', 'Intermediate', 'Advanced')) NOT NULL,
	category NVARCHAR(50) DEFAULT 'None',
	course_image NVARCHAR(MAX) NOT NULL, 
	created_by INT FOREIGN KEY REFERENCES ACCOUNT on delete cascade NOT NULL,
	created_at SMALLDATETIME,
	price INT NOT NULL DEFAULT 0, 
	course_description NVARCHAR(MAX) NOT NULL, 
	stars numeric(4,2) DEFAULT 0,
)

GO

CREATE TABLE CourseModule (
	module_id INT PRIMARY KEY IDENTITY(1,1),
	course_id INT FOREIGN KEY REFERENCES COURSE on delete cascade NOT NULL,
	module_name NVARCHAR(MAX) NOT NULL, 
)

GO

CREATE TABLE CourseResource (
	resource_id INT PRIMARY KEY IDENTITY(1,1),
	module_id INT FOREIGN KEY REFERENCES CourseModule on delete cascade NOT NULL,
	resource_name NVARCHAR(MAX) NOT NULL, 
	resource_type INT NOT NULL,
	resource_filename NVARCHAR(MAX) NOT NULL, 
	allow_download INT NOT NULL DEFAULT 0,
)

GO
CREATE TABLE CourseTest (
	test_id INT PRIMARY KEY IDENTITY(1,1),
	resource_id INT FOREIGN KEY REFERENCES CourseResource on delete cascade NOT NULL,
	mandatory INT NOT NULL,
	test_maxtime TIME NOT NULL,
	total_score INT NOT NULL,
	score_to_pass INT NOT NULL,
)

GO
CREATE TABLE TestQuestion (
	question_id INT PRIMARY KEY IDENTITY(1,1),
	test_id INT FOREIGN KEY REFERENCES COURSETEST on delete cascade NOT NULL,
	question_description NVARCHAR(MAX) NOT NULL, 
	question_type INT NOT NULL,
	choices NVARCHAR(MAX) NOT NULL,
	answer NVARCHAR(MAX) NOT NULL, 
	score INT NOT NULL,
)

GO
CREATE TABLE Register (
	register_id INT PRIMARY KEY IDENTITY(1,1),
	learner_id INT REFERENCES ACCOUNT NOT NULL,
	course_id INT REFERENCES COURSE NOT NULL,
	registered_date DATETIME NOT NULL,
	register_status INT NOT NULL, 
	completion_score FLOAT,
	course_certificate NVARCHAR(MAX), 
)

GO

CREATE TABLE CourseReview (
	review_id INT PRIMARY KEY IDENTITY(1,1),
	register_id INT FOREIGN KEY REFERENCES Register on delete cascade NOT NULL,
	review_time DATETIME NOT NULL,
	content NVARCHAR(MAX) NOT NULL, 
	stars INT DEFAULT 0,
)

GO

CREATE TABLE TestResult (
	result_id INT PRIMARY KEY IDENTITY(1,1),
	register_id INT FOREIGN KEY REFERENCES Register on delete cascade NOT NULL,
	test_id INT FOREIGN KEY REFERENCES CourseTest on delete cascade NOT NULL,
	test_ordinal INT NOT NULL,
	test_score INT NOT NULL,
	test_time TIME NOT NULL,
	is_passed INT NOT NULL,
)

alter table TestQuestion add question_order int

-- Trigger for handling INSERT operations
CREATE TRIGGER trg_Insert_TestQuestion
ON TestQuestion
AFTER INSERT
AS
BEGIN
    DECLARE @test_id INT, @max_order INT;

    -- Get the test_id from the inserted row
    SELECT @test_id = test_id FROM inserted;

    -- Find the maximum order for the questions in the same test
    SELECT @max_order = ISNULL(MAX(question_order), 0) FROM TestQuestion WHERE test_id = @test_id;

    -- Update the inserted row with the next available order
    UPDATE TestQuestion
    SET question_order = @max_order + 1
    WHERE question_id IN (SELECT question_id FROM inserted);
END
GO

-- Trigger for handling DELETE operations
CREATE TRIGGER trg_Delete_TestQuestion
ON TestQuestion
AFTER DELETE
AS
BEGIN
    DECLARE @test_id INT, @deleted_order INT;

    -- Get the test_id and the deleted order from the deleted row
    SELECT @test_id = test_id, @deleted_order = question_order FROM deleted;

    -- Update the order of the following questions
    UPDATE TestQuestion
    SET question_order = question_order - 1
    WHERE test_id = @test_id AND question_order > @deleted_order;
END
GO

CREATE TRIGGER trg_Insert_CourseResource
ON CourseResource
AFTER INSERT
AS
BEGIN
    -- Insert a new test for each inserted resource with resource_type = 2
    INSERT INTO CourseTest (resource_id, mandatory, test_maxtime, total_score, score_to_pass)
    SELECT 
        resource_id,
        0,  -- default value for mandatory
        '00:00:00',  -- default value for test_maxtime
        0,  -- default value for total_score
        0   -- default value for score_to_pass
    FROM inserted
    WHERE resource_type = 2;
END
GO