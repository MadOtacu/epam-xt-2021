class Service
{
    collection = [];

    add(appendableObject)
    {

        this.collection.push(appendableObject);
    }

    getById(findableObjectId)
    {
        return this.collection[findableObjectId];
    }

    getAll()
    {
        return this.collection;
    }

    deleteById(deletableObjectId)
    {
        let deletedValue = this.collection[deletableObjectId];

        this.collection.splice(deletableObjectId, 1)

        return deletedValue;
    }

    updateById(updatableObjectId, sourceObject){
        if(updatableObjectId){
            for(let key of Object.keys(updatableObjectId)){
                updatableObjectId[key] = sourceObject[key];
            }
        }else return null;
    }

    replaceById(replaceableObjectId, sourceObject)
    {
        this.collection[replaceableObjectId] = sourceObject;
    }
}

const storage = new Service();
