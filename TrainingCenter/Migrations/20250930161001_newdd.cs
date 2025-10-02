using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingCenter.Migrations
{
    /// <inheritdoc />
    public partial class newdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courses_courseAdvances_CourseAdvanceId",
                table: "courses");

            migrationBuilder.DropForeignKey(
                name: "FK_courses_courseFoundationals_CourseFoundationalId",
                table: "courses");

            migrationBuilder.DropTable(
                name: "courseAdvances");

            migrationBuilder.DropTable(
                name: "courseFoundationals");

            migrationBuilder.DropTable(
                name: "courseCodes");

            migrationBuilder.DropTable(
                name: "studentCourses");

            migrationBuilder.DropTable(
                name: "subjectTypes");

            migrationBuilder.DropTable(
                name: "subject_Advances");

            migrationBuilder.DropTable(
                name: "subject_Fondationals");

            migrationBuilder.DropTable(
                name: "examTypes");

            migrationBuilder.DropTable(
                name: "lectuerTypes");

            migrationBuilder.DropTable(
                name: "ExamAdvancces");

            migrationBuilder.DropTable(
                name: "examFoundationals");

            migrationBuilder.DropTable(
                name: "lectuer_Advans");

            migrationBuilder.DropTable(
                name: "lectuer_Founds");

            migrationBuilder.DropIndex(
                name: "IX_courses_CourseAdvanceId",
                table: "courses");

            migrationBuilder.DropIndex(
                name: "IX_courses_CourseFoundationalId",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "CourseAdvan",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "CourseAdvanceId",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "CourseFound",
                table: "courses");

            migrationBuilder.RenameColumn(
                name: "CourseFoundationalId",
                table: "courses",
                newName: "CourseCode");

            migrationBuilder.AddColumn<string>(
                name: "CourseName",
                table: "courses",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseName",
                table: "courses");

            migrationBuilder.RenameColumn(
                name: "CourseCode",
                table: "courses",
                newName: "CourseFoundationalId");

            migrationBuilder.AddColumn<int>(
                name: "CourseAdvan",
                table: "courses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseAdvanceId",
                table: "courses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseFound",
                table: "courses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "courseCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeAdvancedCourse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodeFoundationalCourse = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courseCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExamAdvancces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamAdvancces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "examFoundationals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_examFoundationals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "lectuer_Advans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lectuer_Advans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "lectuer_Founds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lectuer_Founds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "studentCourses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MidelName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentCourses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "examTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamAdvancceId = table.Column<int>(type: "int", nullable: true),
                    ExamFoundationalsId = table.Column<int>(type: "int", nullable: true),
                    Exam_Advnv = table.Column<int>(type: "int", nullable: true),
                    Exam_Found = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_examTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_examTypes_ExamAdvancces_ExamAdvancceId",
                        column: x => x.ExamAdvancceId,
                        principalTable: "ExamAdvancces",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_examTypes_examFoundationals_ExamFoundationalsId",
                        column: x => x.ExamFoundationalsId,
                        principalTable: "examFoundationals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "lectuerTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lectuer_AdvanId = table.Column<int>(type: "int", nullable: false),
                    Lectuer_FoundId = table.Column<int>(type: "int", nullable: true),
                    LectuerAdvan = table.Column<int>(type: "int", nullable: true),
                    LectuerFound = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lectuerTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_lectuerTypes_lectuer_Advans_Lectuer_AdvanId",
                        column: x => x.Lectuer_AdvanId,
                        principalTable: "lectuer_Advans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_lectuerTypes_lectuer_Founds_Lectuer_FoundId",
                        column: x => x.Lectuer_FoundId,
                        principalTable: "lectuer_Founds",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "subject_Advances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamTypeId = table.Column<int>(type: "int", nullable: true),
                    LectuerTypeId = table.Column<int>(type: "int", nullable: true),
                    Lectuer_type_id = table.Column<int>(type: "int", nullable: true),
                    examstype = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subject_Advances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_subject_Advances_examTypes_ExamTypeId",
                        column: x => x.ExamTypeId,
                        principalTable: "examTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_subject_Advances_lectuerTypes_LectuerTypeId",
                        column: x => x.LectuerTypeId,
                        principalTable: "lectuerTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "subject_Fondationals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamTypeId = table.Column<int>(type: "int", nullable: true),
                    LectuerTypeId = table.Column<int>(type: "int", nullable: true),
                    Lectuer_type_id = table.Column<int>(type: "int", nullable: true),
                    examstype = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subject_Fondationals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_subject_Fondationals_examTypes_ExamTypeId",
                        column: x => x.ExamTypeId,
                        principalTable: "examTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_subject_Fondationals_lectuerTypes_LectuerTypeId",
                        column: x => x.LectuerTypeId,
                        principalTable: "lectuerTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "subjectTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject_FondationalsId = table.Column<int>(type: "int", nullable: true),
                    Subjects_AdvancesId = table.Column<int>(type: "int", nullable: true),
                    Subjects_fond = table.Column<int>(type: "int", nullable: true),
                    subject_Adv = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subjectTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_subjectTypes_subject_Advances_Subjects_AdvancesId",
                        column: x => x.Subjects_AdvancesId,
                        principalTable: "subject_Advances",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_subjectTypes_subject_Fondationals_Subject_FondationalsId",
                        column: x => x.Subject_FondationalsId,
                        principalTable: "subject_Fondationals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "courseAdvances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseCodeId = table.Column<int>(type: "int", nullable: true),
                    StudentCourseId = table.Column<int>(type: "int", nullable: true),
                    SubjectTypeId = table.Column<int>(type: "int", nullable: true),
                    courseCodes_Id = table.Column<int>(type: "int", nullable: true),
                    stud_course_id = table.Column<int>(type: "int", nullable: false),
                    subjectyapes = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courseAdvances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_courseAdvances_courseCodes_CourseCodeId",
                        column: x => x.CourseCodeId,
                        principalTable: "courseCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_courseAdvances_studentCourses_StudentCourseId",
                        column: x => x.StudentCourseId,
                        principalTable: "studentCourses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_courseAdvances_subjectTypes_SubjectTypeId",
                        column: x => x.SubjectTypeId,
                        principalTable: "subjectTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "courseFoundationals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseCodeId = table.Column<int>(type: "int", nullable: true),
                    StudentCourseId = table.Column<int>(type: "int", nullable: true),
                    SubjectTypeId = table.Column<int>(type: "int", nullable: true),
                    courseCodes_Id = table.Column<int>(type: "int", nullable: true),
                    stud_course_id = table.Column<int>(type: "int", nullable: false),
                    subjectyapes = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courseFoundationals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_courseFoundationals_courseCodes_CourseCodeId",
                        column: x => x.CourseCodeId,
                        principalTable: "courseCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_courseFoundationals_studentCourses_StudentCourseId",
                        column: x => x.StudentCourseId,
                        principalTable: "studentCourses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_courseFoundationals_subjectTypes_SubjectTypeId",
                        column: x => x.SubjectTypeId,
                        principalTable: "subjectTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_courses_CourseAdvanceId",
                table: "courses",
                column: "CourseAdvanceId");

            migrationBuilder.CreateIndex(
                name: "IX_courses_CourseFoundationalId",
                table: "courses",
                column: "CourseFoundationalId");

            migrationBuilder.CreateIndex(
                name: "IX_courseAdvances_CourseCodeId",
                table: "courseAdvances",
                column: "CourseCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_courseAdvances_StudentCourseId",
                table: "courseAdvances",
                column: "StudentCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_courseAdvances_SubjectTypeId",
                table: "courseAdvances",
                column: "SubjectTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_courseFoundationals_CourseCodeId",
                table: "courseFoundationals",
                column: "CourseCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_courseFoundationals_StudentCourseId",
                table: "courseFoundationals",
                column: "StudentCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_courseFoundationals_SubjectTypeId",
                table: "courseFoundationals",
                column: "SubjectTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_examTypes_ExamAdvancceId",
                table: "examTypes",
                column: "ExamAdvancceId");

            migrationBuilder.CreateIndex(
                name: "IX_examTypes_ExamFoundationalsId",
                table: "examTypes",
                column: "ExamFoundationalsId");

            migrationBuilder.CreateIndex(
                name: "IX_lectuerTypes_Lectuer_AdvanId",
                table: "lectuerTypes",
                column: "Lectuer_AdvanId");

            migrationBuilder.CreateIndex(
                name: "IX_lectuerTypes_Lectuer_FoundId",
                table: "lectuerTypes",
                column: "Lectuer_FoundId");

            migrationBuilder.CreateIndex(
                name: "IX_subject_Advances_ExamTypeId",
                table: "subject_Advances",
                column: "ExamTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_subject_Advances_LectuerTypeId",
                table: "subject_Advances",
                column: "LectuerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_subject_Fondationals_ExamTypeId",
                table: "subject_Fondationals",
                column: "ExamTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_subject_Fondationals_LectuerTypeId",
                table: "subject_Fondationals",
                column: "LectuerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_subjectTypes_Subject_FondationalsId",
                table: "subjectTypes",
                column: "Subject_FondationalsId");

            migrationBuilder.CreateIndex(
                name: "IX_subjectTypes_Subjects_AdvancesId",
                table: "subjectTypes",
                column: "Subjects_AdvancesId");

            migrationBuilder.AddForeignKey(
                name: "FK_courses_courseAdvances_CourseAdvanceId",
                table: "courses",
                column: "CourseAdvanceId",
                principalTable: "courseAdvances",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_courses_courseFoundationals_CourseFoundationalId",
                table: "courses",
                column: "CourseFoundationalId",
                principalTable: "courseFoundationals",
                principalColumn: "Id");
        }
    }
}
