#!/usr/bin/env node

const fs = require('fs')
const path = require('path')

function removeUnnecessaryUnionOptions() {

  {
    // Authentication.cs
    const file = `${process.cwd()}/../../generated/Models/Authentication.cs`

    const fileData = fs.readFileSync(file)
    let fileAsStr = fileData.toString('utf8')

    fileAsStr = fileAsStr.replace(/ObjectType = new AuditedObjectType\("Authentication"\);/, 'ObjectType = AuditedObjectType.Authentication;')

    fs.writeFileSync(file, fileAsStr, 'utf8')
  }

  {
    // Process.cs
    const file = `${process.cwd()}/../../generated/Models/Process.cs`

    const fileData = fs.readFileSync(file)
    let fileAsStr = fileData.toString('utf8')

    fileAsStr = fileAsStr.replace(/ObjectType = new AuditedObjectType\("Process"\);/, 'ObjectType = AuditedObjectType.Process;')

    fs.writeFileSync(file, fileAsStr, 'utf8')
  }

  {
    // Task.cs
    const file = `${process.cwd()}/../../generated/Models/Task.cs`

    const fileData = fs.readFileSync(file)
    let fileAsStr = fileData.toString('utf8')

    fileAsStr = fileAsStr.replace(/ObjectType = new AuditedObjectType\("Task"\);/, 'ObjectType = AuditedObjectType.Task;')

    fs.writeFileSync(file, fileAsStr, 'utf8')
  }

  {
    // KuflowRestModelFactory.cs
    const file = `${process.cwd()}/../../generated/KuflowRestModelFactory.cs`

    const fileData = fs.readFileSync(file)
    let fileAsStr = fileData.toString('utf8')

    fileAsStr = fileAsStr.replace(/return new Authentication\("Authentication"/, 'return new Authentication(AuditedObjectType.Authentication')

    fs.writeFileSync(file, fileAsStr, 'utf8')
  }

  // TODO The generator create code in .net 7.0, but for now we required 6.0
  {
    const dirPath = `${process.cwd()}/../../generated/Models`
    fs.readdir(dirPath, (err, files) => {
      if (err) {
        console.error('Error reading directory:', err);
        return;
      }

      files.forEach(file => {
        const filePath = path.join(dirPath, file);

        const fileData = fs.readFileSync(filePath)
        let fileAsStr = fileData.toString('utf8')


        fileAsStr = fileAsStr.replace(new RegExp('"u8', 'g'), '"')
        console.log(filePath)
        fs.writeFileSync(filePath, fileAsStr, 'utf8')
      });
    });
  }


}

removeUnnecessaryUnionOptions()
