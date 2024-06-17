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

alter table CourseTest add display_type int check (display_type in (0, 1)) default 0 -- 0 -> hien all cau trong 1 trang, 1 -> hien 1 cau 1 trang

go

alter table Course add discount int check (discount >= 0 and discount <= 100) default 0 -- phan tram giam gia
alter table Course add discount_end_date smalldatetime
go

alter table CourseModule add description nvarchar(256) -- mo ta module
alter table CourseTest add max_attempt int -- so lan test toi da
alter table TestResult add time_start datetime -- thoi gian bat dau
alter table TestResult add time_finish datetime -- thoi gian ket thuc

alter table Register add time_finish datetime -- thoi gian hoan thanh

go

update Course set discount = 0 where discount is null
update CourseTest set display_type = 0 where display_type is null
update CourseModule set description = '' where description is null