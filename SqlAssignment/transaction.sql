BEGIN TRY
	BEGIN TRANSACTION
		
		UPDATE dbo.Athletes
		SET AthleteName = 'beni update'
		WHERE ID = 5

		UPDATE dbo.Exercises
		SET ExerciseName = 'BenchPressUpdate',
			Category = 'ChestUpdate'
		WHERE ID = 1

		UPDATE Sets
		SET ExerciseId = 3
		WHERE ID = 1

		DELETE FROM dbo.Exercises
		WHERE ExerciseName LIKE 'Incline Dumbbell Press'

		DELETE FROM dbo.Athletes
		WHERE ID = 1

	COMMIT TRANSACTION
END TRY

BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH