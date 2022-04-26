import React, {useEffect, useState} from 'react';
import LoadingSpinner from "./LoadingSpinner";
import NoteCard from "./NoteCard";

export default function NoteList({eventId}) {
    const [notesData, setNotesData] = useState([]);
    const [isFetching, setIsFetching] = useState(true);

    const requestOptions = {
        headers: {
            'Session': `${localStorage.getItem("session")}`,
            'Event': `${eventId}`,
        }
    }

    useEffect(() => {
        if (eventId != null) {
            fetch(`api/UserNote/event-notes`, requestOptions)
                .then(response => {
                    if (response.ok) {
                        return response.json();
                    }
                    throw response;
                })
                .then(data => {
                    console.log(data);
                    setNotesData(data);
                })
                .then(() => {
                    setIsFetching(false);
                })
                .catch(error => {
                    console.error("Error fetching data: ", error);
                })
        }
    }, [eventId]);

    if (!isFetching) {
        if (notesData.length === 0) {
            return (
                <div style={{ textAlign: "center" }}>
                    <div>There is no notes.</div>
                    <div>Create your first one!</div>
                </div>
            )
        } else {
            return notesData.map((note) =>
                (<NoteCard key={note.noteId}
                           noteId={note.noteId}
                           time={note.time}
                           title={note.title}
                           message={note.message}/>))
        }
    } else {
        return (
            <div>
                <LoadingSpinner/>
            </div>
        )
    }
}