INSERT INTO dbo.PrimaryMuscles (PrimaryMuscleName)
VALUES
('Chest'),
('Quadriceps'),
('Biceps'),
('Triceps'),
('Hamstrings'),
('Calves'),
('Glutes'),
('Front Delts'),
('Lower Back')

INSERT INTO dbo.SecondaryMuscles (SecondaryMuscleName)
VALUES
('Chest'),
('Quadriceps'),
('Biceps'),
('Triceps'),
('Hamstrings'),
('Calves'),
('Glutes'),
('Front Delts'),
('Lower Back')

INSERT INTO dbo.Exercises(ExerciseName,Category,Equipment)
VALUES
('BenchPress', 'Chest', 'Bench, Barbell'),
('Cable Crossover', 'Chest', 'Cable Machine'),
('Dumbbell Flies', 'Chest', 'Bench, Dumbbells'),
('Dumbbell Press', 'Chest', 'Bench, Dumbbells'),
('Incline Benchpress', 'Chest', 'Bench, Barbell'),
('Incline Dumbbell Press', 'Chest', 'Bench, Dumbbells'),
('Squat', 'Legs', 'Bench, Barbell'),
('Calf Raises', 'Legs', 'Bench, Barbell'),
('Front Squat', 'Legs', 'Barbell'),
('Leg Curls', 'Legs', 'Leg Curls Machine'),
('Leg Extensions', 'Legs', 'Leg Extension Machine')

INSERT INTO dbo.SecondaryMusclesExercises (SecondaryMuscleId, ExerciseId)
VALUES
(4, 1),
(8, 1),
(4, 2),
(8, 2),
(7, 7),
(5, 7)

INSERT INTO dbo.PrimaryMusclesExercises (PrimaryMuscleId, ExerciseId)
VALUES
(1, 1),
(1,2),
(2, 7),
(5, 8)

INSERT INTO dbo.WorkoutPlans (WorkoutPlanName, TimesPerWeek)
VALUES
('Push-Pull-Legs', 4)

INSERT INTO dbo.WorkoutRoutines (RoutineName, WorkoutPlanId)
VALUES
('Push1', 1),
('Legs1', 1),
('Push2',1),
('Legs2',1)

INSERT INTO dbo.Sets (Weight, NumOfReps, WorkoutRoutineId, EXerciseId)
VALUES
(40, 8, 1, 1),
(50,10,1,1),
(50,10,1,2),
(50,10,1,2),
(50,10,1,3),
(55,6,2,7),
(15,12,2,8),
(45, 8, 3, 1),
(65,6,3,1),
(50,10,3,2),
(50,10,3,2),
(80,6,4,7),
(70,6,4,7),
(25,12,4,8),
(15,12,4,8)

INSERT INTO dbo.Athletes (AthleteName, WorkoutPlanId)
VALUES
('Jeff Nippard', 1),
('Ronnie Coleman', 1),
('Knut', 1),
('Jeff Cavaliere', 1),
('Eric Bugenhagen', 1)

INSERT INTO dbo.CompletedRoutines(AthleteId, WorkoutRoutineId)
VALUES
(1, 1),
(1, 2),
(1, 2),
(2, 1),
(2, 3),
(2, 4),
(3, 1),
(3, 3),
(3, 2),
(3, 2),
(3, 4),
(3, 4)