pipeline {
    agent any

    stages {
        stage('Build and Test') {
        steps {
               dir("timetrackerbackend"){
                sh 'make test'
              }
            }
        }

    }
}