/* Get the number of exercises available for each category */

SELECT COUNT(ID) AS 'Number of exercises', Category
FROM dbo.Exercises
GROUP BY Category
Order By COUNT(ID) DESC

/* Get the total number of exercises*/

SELECT COUNT(*) AS 'Number of exercises' FROM dbo.Exercises

/*Get the most used exercises in a workoutplan  */

SELECT	a.AthleteName,
		wp.WorkoutPlanName,
		wr.RoutineName,
		e.ExerciseName,
		COUNT(e.ID) AS total
FROM dbo.Athletes AS a
	RIGHT JOIN dbo.WorkoutPlans AS wp
		ON a.WorkoutPlanId = wp.ID
	RIGHT JOIN dbo.WorkoutRoutines AS wr
		ON wp.ID = wr.WorkoutPlanId
	INNER JOIN dbo.Sets AS s
		ON wr.ID = s.WorkoutRoutineId
	INNER JOIN dbo.Exercises AS e
		ON s.ExerciseId = e.ID
GROUP BY a.AthleteName, wp.WorkoutPlanName, wr.RoutineName, e.ExerciseName
ORDER BY total desc

/*Get the number of workouts completed*/

SELECT	a.AthleteName,
		COUNT(cr.AthleteId) as total
FROM dbo.Athletes AS a
	INNER JOIN dbo.CompletedRoutines AS cr
		ON a.ID = cr.AthleteId
GROUP BY a.AthleteName

/*Get volume of weight lifted for each muscle category */

SELECT	a.AthleteName,
		e.Category,
		Sum(s.Weight) as total
FROM dbo.Athletes AS a 
	INNER JOIN dbo.CompletedRoutines AS cr
		ON a.ID = cr.AthleteId
	INNER JOIN dbo.Sets AS s
		ON cr.WorkoutRoutineId = s.WorkoutRoutineId
	INNER JOIN dbo.Exercises AS e
		ON s.ExerciseId = e.ID
Group By a.AthleteName, e.Category
ORDER BY total DESC

/*Get the exercises where the primary muscle used is quadriceps*/

SELECT	e.ExerciseName,
		e.Category,
		e.Equipment,
		pm.PrimaryMuscleName
FROM dbo.Exercises AS e
	INNER JOIN dbo.PrimaryMusclesExercises AS me
		ON e.ID = me.ExerciseId
	INNER JOIN dbo.PrimaryMuscles AS pm
		ON me.PrimaryMuscleId = pm.ID
WHERE pm.PrimaryMuscleName LIKE 'Quadriceps'

/*Get the total number of reps done*/

SELECT	a.AthleteName,
		SUM(s.NumOfReps) as total
FROM dbo.Athletes AS a
	INNER JOIN dbo.CompletedRoutines AS cr
		ON a.ID = cr.AthleteId
	INNER JOIN dbo.Sets AS s
		ON s.WorkoutRoutineId = cr.WorkoutRoutineId
GROUP BY a.AthleteName
ORDER BY total DESC

/*Get the total average number of reps done*/

SELECT	a.AthleteName,
		AVG(s.NumOfReps) as total
FROM dbo.Athletes AS a
	INNER JOIN dbo.CompletedRoutines AS cr
		ON a.ID = cr.AthleteId
	INNER JOIN dbo.Sets AS s
		ON s.WorkoutRoutineId = cr.WorkoutRoutineId
GROUP BY a.AthleteName
ORDER BY total DESC

/*Get the total number of sets done*/

SELECT	a.AthleteName,
		Count(s.Id) as total
FROM dbo.Athletes AS a
	INNER JOIN dbo.CompletedRoutines AS cr
		ON a.ID = cr.AthleteId
	INNER JOIN dbo.Sets AS s
		ON s.WorkoutRoutineId = cr.WorkoutRoutineId
GROUP BY a.AthleteName
ORDER BY total DESC

/*Get the exercises where the secondary muscle used is triceps*/

SELECT	e.ExerciseName,
		e.Category,
		e.Equipment,
		sm.SecondaryMuscleName
FROM dbo.Exercises AS e
	INNER JOIN dbo.SecondaryMusclesExercises AS me
		ON e.ID = me.ExerciseId
	INNER JOIN dbo.SecondaryMuscles AS sm
		ON me.SecondaryMuscleId = sm.ID
WHERE sm.SecondaryMuscleName LIKE 'Triceps'