import { Popover, Switch } from '@headlessui/react'
import { useState } from 'react'

function InstantBookFilter() {

    const [enabled, setEnabled] = useState(false)
    
    return (
    <Popover className="relative border-0">
        <Popover.Button className="focus:outline-none"><p className="filter-button">Instant Book</p></Popover.Button>
        <Popover.Panel className="absolute z-10 w-screen max-w-[350px] px-4 mt-3 transform -translate-x-1/2 left-1/2 sm:px-0">
        <div className="overflow-hidden rounded-lg shadow-lg ring-1 ring-black ring-opacity-5">
            <div className="bg-white">
              <div className="flex flex-grow justify-between items-center py-10 px-5">
                <div>
                    <h4>Instant Book</h4>
                    <div className="text-md text-gray-400 font-light leading-none">
                      <p>Listings you can book without</p>
                      <p>waiting for Host approval</p>
                    </div>
                </div>
                <Switch
                    checked={enabled}
                    onChange={setEnabled}
                    className={`${enabled ? 'bg-red-400' : 'bg-gray-200'}
                    relative inline-flex flex-shrink-0 h-[32px] w-[60px] border-2 border-transparent rounded-full cursor-pointer transition-colors ease-in-out duration-200 focus:outline-none focus-visible:ring-2  focus-visible:ring-white focus-visible:ring-opacity-75`}
                >
                    <span className="sr-only">Use setting</span>
                    <span
                    aria-hidden="true"
                    className={`${enabled ? 'translate-x-7' : 'translate-x-0'}
                        pointer-events-none inline-block h-[28px] w-[28px] rounded-full bg-white shadow-lg transform ring-0 transition ease-in-out duration-200`}
                    />
                </Switch>
              </div>
              <div className="border-b"/>
              <div className="px-3 p-2 flex flex-row-reverse">
                <button className="save-button">Save</button>
              </div>
            </div>
        </div>    
        </Popover.Panel>
            
       
      </Popover>
      )
}

export default InstantBookFilter
